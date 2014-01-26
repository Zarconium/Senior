package admu.cs119.login.ui;

import java.util.HashMap;

import org.apache.commons.codec.binary.Hex;
import org.apache.commons.codec.digest.DigestUtils;

import admu.cs119.login.R;
import admu.cs119.login.model.ServerReply;
import admu.cs119.login.service.RegistrationService;
import admu.cs119.login.validator.NotEmptyRule;
import admu.cs119.login.validator.RegExRule;
import admu.cs119.login.validator.Validator;
import android.content.Context;
import android.content.Intent;
import android.os.Bundle;
import android.os.Handler;
import android.os.Message;
import android.os.Messenger;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.Toast;

public class RegistrationDialog extends CustomDialog
{
	public RegistrationDialog(Context context) 
	{
		super(context);
	}
	
	@Override
	public void onCreate(Bundle savedInstanceState)
	{
		super.onCreate(savedInstanceState);
		setContentView(R.layout.registration_field_layout);
		setTitle("New User");

		Button register = (Button) findViewById(R.id.register);
		register.setOnClickListener(new View.OnClickListener() {
			
			@Override
			public void onClick(View arg0) 
			{				
				register();
			}
		});
		
		Button cancel = (Button) findViewById(R.id.cancel);
		cancel.setOnClickListener(new View.OnClickListener() {
			
			@Override
			public void onClick(View arg0) 
			{				
				cancel();
			}
		});
		
		
		initializeSpinners();
		
		initializeValidators();
	}

	private void initializeSpinners()
	{
	}
	
	private Validator validator = new Validator();

	private void initializeValidators()
	{
		NotEmptyRule notEmptyRule = new NotEmptyRule();
		
		validator.addViewForValidation(findViewById(R.id.firstname), notEmptyRule);
		validator.addViewForValidation(findViewById(R.id.lastname), notEmptyRule);
		validator.addViewForValidation(findViewById(R.id.username), notEmptyRule);
		validator.addViewForValidation(findViewById(R.id.password), notEmptyRule);
		validator.addViewForValidation(findViewById(R.id.password2), notEmptyRule);
		validator.addViewForValidation(findViewById(R.id.email), notEmptyRule, new RegExRule(".+@.+(\\..+)+", "Invalid email address"));
	}
	
	private void register()
	{
		EditText password1 = (EditText) findViewById(R.id.password);
		EditText password2 = (EditText) findViewById(R.id.password2);

		try
		{
			validator.validate();
			
			
			String p1 = password1.getText().toString();
			String p2 = password2.getText().toString();
			if (!p1.equals(p2))
			{
				throw new RuntimeException("Password and Confirm Password do not match");
			}
		}
		catch(Exception e)
		{
			if (e.getMessage()!=null)
			{
				Toast.makeText(getContext(), e.getMessage(), Toast.LENGTH_LONG).show();
			}
			return;
		}
		
		
		// create registration info
		EditText firstname = (EditText) findViewById(R.id.firstname);
		EditText lastname = (EditText) findViewById(R.id.lastname);
		EditText username = (EditText) findViewById(R.id.username);
		EditText email = (EditText) findViewById(R.id.email);

		
		registrationInfo = new HashMap<String, String>();
		registrationInfo.put(RegistrationService.REGISTRATION_FIRST_NAME, firstname.getText().toString());
		registrationInfo.put(RegistrationService.REGISTRATION_LAST_NAME, lastname.getText().toString());
		registrationInfo.put(RegistrationService.REGISTRATION_USERNAME, username.getText().toString());
		registrationInfo.put(RegistrationService.REGISTRATION_PASSWORD, hashPassword(password1.getText().toString()));
		registrationInfo.put(RegistrationService.REGISTRATION_EMAIL, email.getText().toString());
		
		register(registrationInfo);
	}
	

	public HashMap<String, String> registrationInfo;
	
	
	public void precancel()
	{
		registrationInfo = null;
	}
	
	private String hashPassword(String password)
	{
		String md5Hex = new String(Hex.encodeHex(DigestUtils.md5(password)));
		return md5Hex;
	}
	
	
	
	private void register(HashMap<String, String> registrationInfo)
	{
		final View progress = findViewById(R.id.progressBar);

		Intent intent = new Intent(getContext(), RegistrationService.class);
		
		// pass info
		intent.putExtra(RegistrationService.REGISTRATION_INFO, registrationInfo);
		
		// define what will happen once the action is done
		Messenger messenger = new Messenger(new Handler()
		{
	    	public void handleMessage(Message message) 
	    	{
	    		ServerReply reply = (ServerReply) message.obj;
    			Toast.makeText(getContext(), reply.getMessage(), Toast.LENGTH_LONG).show();

    			if (message.arg1==RegistrationService.REGISTRATION_RESULT_OK)
	    		{
	    			dismiss();
	    		}
	    		
				progress.setVisibility(View.INVISIBLE);
	    	}
		});
		
		
		// attach this messenger
		intent.putExtra(RegistrationService.REGISTRATION_MESSENGER, messenger);

		progress.setVisibility(View.VISIBLE);

		// start the service
		getContext().startService(intent);
	}
}

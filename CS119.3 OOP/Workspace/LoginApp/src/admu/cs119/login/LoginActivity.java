package admu.cs119.login;

import admu.cs119.login.model.ServerReply;
import admu.cs119.login.service.LoginService;
import admu.cs119.login.ui.RegistrationDialog;
import android.app.Activity;
import android.content.Intent;
import android.content.SharedPreferences;
import android.os.Bundle;
import android.os.Handler;
import android.os.Message;
import android.os.Messenger;
import android.preference.PreferenceManager;
import android.view.View;
import android.widget.CheckBox;
import android.widget.TextView;
import android.widget.Toast;


public class LoginActivity extends Activity 
{
	
	@Override
	protected void onCreate(Bundle savedInstanceState) {
		super.onCreate(savedInstanceState);
			
		setContentView(R.layout.activity_login);
		SharedPreferences prefs = PreferenceManager.getDefaultSharedPreferences(getBaseContext());
		boolean rememberMe = prefs.getBoolean("rememberme", false);
		CheckBox cb = (CheckBox) findViewById(R.id.remember_me);
		cb.setChecked(rememberMe);
		
		if (rememberMe)
		{
			String username = prefs.getString("username", "");
			String password = prefs.getString("password", "");

			TextView usernameField = (TextView) findViewById(R.id.user_name);
			TextView passwordField = (TextView) findViewById(R.id.password);

			usernameField.setText(username);
			passwordField.setText(password);
			
		}
	}

	public void register(View v)
	{
		// open registration dialog
		
		// trigger the registration process in dismiss listener to use progress

		RegistrationDialog dialog = new RegistrationDialog(this);
		dialog.show();	
	}

	
	public void login(View v)
	{
		final View progress = findViewById(R.id.mainProgressBar);

		
		CheckBox cb = (CheckBox) findViewById(R.id.remember_me);
		if (cb.isChecked())
		{
			TextView username = (TextView) findViewById(R.id.user_name);
			TextView password = (TextView) findViewById(R.id.password);
			
			saveCredentials(username.getText().toString(), password.getText().toString());
		}
		else
		{
			resetCredentials();
		}
		
		
		Intent intent = new Intent(this, LoginService.class);
		
		TextView username = (TextView) findViewById(R.id.user_name);
		TextView password = (TextView) findViewById(R.id.password);
		
		// pass credentials
		intent.putExtra(LoginService.AUTHENTICATION_USERNAME, username.getText().toString());
		intent.putExtra(LoginService.AUTHENTICATION_PASSWORD, password.getText().toString());
		
		// define what will happen once the action is done
		Messenger messenger = new Messenger(new Handler()
		{
	    	public void handleMessage(Message message) 
	    	{
	    		if (message.arg1==LoginService.AUTHENTICATION_RESULT_OK)
	    		{
		    		ServerReply reply = (ServerReply) message.obj;
		    		
		    		Toast.makeText(getApplicationContext(), reply.getMessage(), Toast.LENGTH_LONG).show();
		    		
	    		}
	    		else
	    		{
		    		ServerReply reply = (ServerReply) message.obj;
		    		
		    		Toast.makeText(getApplicationContext(), reply.getMessage(), Toast.LENGTH_LONG).show();
	    		}
	    		
				progress.setVisibility(View.INVISIBLE);
	    	}
		});
		
		
		// attach this messenger
		intent.putExtra(LoginService.AUTHENTICATION_MESSENGER, messenger);

		progress.setVisibility(View.VISIBLE);

		// start the service
		startService(intent);
	}
	
	public void toggleRemember(View v)
	{
		// don't toggle here anymore
	}
	

	private void saveCredentials(String username, String password) 
	{
		SharedPreferences prefs = PreferenceManager.getDefaultSharedPreferences(getBaseContext());

		// save to preferences
		SharedPreferences.Editor editor = prefs.edit();
	    editor.putString("username", username);
	    editor.putString("password", password);
	    editor.putBoolean("rememberme", true);
	    editor.commit();
	}
	
	private void resetCredentials() 
	{
		SharedPreferences prefs = PreferenceManager.getDefaultSharedPreferences(getBaseContext());

		// save to preferences
		SharedPreferences.Editor editor = prefs.edit();
		editor.clear();
	    editor.commit();
	}
}

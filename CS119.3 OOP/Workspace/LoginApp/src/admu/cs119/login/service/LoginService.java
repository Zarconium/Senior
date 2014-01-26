package admu.cs119.login.service;

import java.util.HashMap;

import org.apache.commons.codec.binary.Hex;
import org.apache.commons.codec.digest.DigestUtils;

import admu.cs119.login.model.ServerReply;
import android.app.Activity;
import android.app.IntentService;
import android.content.Intent;
import android.os.Bundle;
import android.os.Message;
import android.os.Messenger;

import com.fasterxml.jackson.databind.ObjectMapper;

public class LoginService extends IntentService 
{
	private String url = Constants.BASE_APP_URL+"/login";

	
	// intent constants
	public static final String AUTHENTICATION_USERNAME = "username";
	public static final String AUTHENTICATION_PASSWORD = "password";
	public static final String AUTHENTICATION_MESSENGER = "AuthMessenger";

	// result constants
	public static final int AUTHENTICATION_RESULT_OK = 1000;
	public static final int AUTHENTICATION_RESULT_NO_CREDENTIALS = 1001;
	public static final int AUTHENTICATION_RESULT_INVALID_CREDENTIALS = 1002;
	public static final int AUTHENTICATION_RESULT_FAILED = Activity.RESULT_CANCELED;

	private int result = AUTHENTICATION_RESULT_FAILED;

	public LoginService() {
		super("AuthenticationService");
	}

	// Will be called asynchronously be Android
	@Override
	protected void onHandleIntent(final Intent intent) 
	{
		processLogin(intent);
	}

	
	// NOTE: maybe its the authentication token that needs to be saved not the username/password
	//		 if the token is invalid go to login
	
	public void processLogin(Intent intent) 
	{
		Bundle extras = intent.getExtras();
		if (extras != null) {

			String username = intent.getStringExtra(AUTHENTICATION_USERNAME);
			String password = intent.getStringExtra(AUTHENTICATION_PASSWORD);
			ServerReply reply = null;
			
			if ((username==null) || (password==null))
			{
				result = AUTHENTICATION_RESULT_NO_CREDENTIALS;
			}
			else
			{
				// authenticate here
				try
				{
					reply = authenticate(username, password);
					

					if (reply.getMessage().equals("Invalid Login"))
					{
						result = AUTHENTICATION_RESULT_INVALID_CREDENTIALS;
					}
					else
					{
						result = AUTHENTICATION_RESULT_OK;
					}
					
				}
				catch(Exception re)
				{
					re.printStackTrace();
					result = AUTHENTICATION_RESULT_FAILED;
				}
			}
			
			// pass result back to application
			Messenger messenger = (Messenger) extras.get(AUTHENTICATION_MESSENGER);
			Message msg = Message.obtain();

			// set authentication result
			msg.obj = reply;
			msg.arg1 = result;

			try 
			{
				messenger.send(msg);
			} 
			catch (android.os.RemoteException e1) 
			{
			}
		}
	}

	public ServerReply authenticate(String username, String password) throws Exception
	{
  	    HashMap<String, String> map = new HashMap<String, String>();
  	    map.put("username", username);
  	    map.put("password", hashPassword(password));  // hash this later when API is fixed

		try
		{
	
			ObjectMapper mapper = new ObjectMapper();
			String json = mapper.writeValueAsString(map);
			String reply = NetUtil.postJsonDataToUrl(url, json);
			
			
			// A simple JSON object from the server representing the reply			
			ServerReply serverReply = (ServerReply) JsonUtil.fromJsonToObject(reply, ServerReply.class);
			

			return serverReply;
			
		}
		catch(Exception e)
		{
			throw new RuntimeException("Authentication failed: "+e.getMessage());
		}
		
		
	}
	
	private String hashPassword(String password)
	{
		String md5Hex = new String(Hex.encodeHex(DigestUtils.md5(password)));
		return md5Hex;
	}
	
}

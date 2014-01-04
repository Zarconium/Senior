package admu.cs119.login.service;

import java.util.ArrayList;
import java.util.HashMap;
import java.util.Iterator;


import admu.cs119.login.model.ServerReply;
import android.app.Activity;
import android.app.IntentService;
import android.content.Intent;
import android.os.Bundle;
import android.os.Message;
import android.os.Messenger;

public class RegistrationService extends IntentService 
{
	private String url = Constants.BASE_APP_URL+"/register";

	
	// intent constants
	public static final String REGISTRATION_INFO = "registrationInfo";
	
	
	public static final String REGISTRATION_FIRST_NAME = "firstName";
	public static final String REGISTRATION_LAST_NAME = "lastName";
	public static final String REGISTRATION_USERNAME = "userName";
	public static final String REGISTRATION_PASSWORD = "password";
	public static final String REGISTRATION_EMAIL = "email";
	
	public static final String REGISTRATION_MESSENGER = "AuthMessenger";

	// result constants
	public static final int REGISTRATION_RESULT_OK = 1000;
	public static final int REGISTRATION_RESULT_FAILED = Activity.RESULT_CANCELED;

	private int result = REGISTRATION_RESULT_FAILED;

	public RegistrationService() {
		super("RegistrationService");
	}

	// Will be called asynchronously be Android
	@Override
	protected void onHandleIntent(final Intent intent) 
	{
		processRegistration(intent);
	}

	
	// NOTE: maybe its the REGISTRATION token that needs to be saved not the username/password
	//		 if the token is invalid go to login
	
	public void processRegistration(Intent intent) 
	{
		Bundle extras = intent.getExtras();
		if (extras != null) {

			HashMap<String, String> registrationInfo = (HashMap<String, String>) extras.getSerializable(REGISTRATION_INFO);

			// send to backend here
			ServerReply result = null;
			Messenger messenger = (Messenger) extras.get(REGISTRATION_MESSENGER);
			Message msg = Message.obtain();
			try
			{
				result = register(registrationInfo);
				msg.arg1 = REGISTRATION_RESULT_OK;
				msg.obj = result;
			}
			catch(Exception e)
			{
				e.printStackTrace();
				result = new ServerReply();
				result.setMessage(e.getMessage());
				msg.arg1 = REGISTRATION_RESULT_FAILED;
			}
			

			try 
			{
				messenger.send(msg);
			} 
			catch (android.os.RemoteException e1) 
			{
			}
		}
	}

	private String generateErrorMessage(HashMap<String, ArrayList<String>> errorMap)
	{
		StringBuilder sb = new StringBuilder("Registration Error: ");
		
		for (Iterator<String> i = errorMap.keySet().iterator(); i.hasNext(); )
		{
			String key = i.next();
			String value = (errorMap.get(key)).get(0);
			sb.append(key);
			sb.append(" ");
			sb.append(value);
			
			if (i.hasNext())
			{
				sb.append(", ");
			}
		}
		
		return sb.toString();
	}
	
	private ServerReply register(HashMap<String, String> map)
	{
		try
		{
			String json = JsonUtil.convertToJson(map);
			String reply = NetUtil.postJsonDataToUrl(url, json);
			ServerReply serverReply = (ServerReply) JsonUtil.fromJsonToObject(reply, ServerReply.class);
			return serverReply;			
		}
		catch(Exception e)
		{
			throw new RuntimeException("Registration failed: "+e.getMessage());
		}
		
		
	}
}

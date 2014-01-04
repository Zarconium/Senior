package admu.cs119.login.service;

import android.app.IntentService;
import android.content.Intent;
import android.os.Message;
import android.os.Messenger;

public abstract class BaseService extends IntentService 
{
	// required parameters
	public static final String MESSENGER = "Messenger";
	public static final String FILTERS = "Filters";

	
	public BaseService(String name) {
		super(name);
	}

	@Override
	protected final void onHandleIntent(Intent intent) 
	{
		// TODO Auto-generated method stub
		process(intent);
	}
	
	protected String addAuthenticationToken(String url)
	{
		return url;
	}
	
	protected abstract void process(Intent intent);
	
	public void replyToUi(Object data, int result, Messenger messenger) {
		try
		{
			Message msg = Message.obtain();
			msg.arg1 = result;
			msg.obj = data; 
			messenger.send(msg);
		}
		catch(Exception e)
		{
			e.printStackTrace();
		}
	}
	
}

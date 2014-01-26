package com.example.applicationlifecycle;

import android.os.Bundle;
import android.app.Activity;
import android.view.Menu;

public class MainActivity extends Activity {

    /** Called when the activity is first created. */
    @Override
    public void onCreate(Bundle savedInstanceState) 
    {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        
        System.out.println("onCreate() "+savedInstanceState);
    }
    
    
    @Override
    public void onStart()
    {
    	super.onStart();
    	System.out.println("onStart()");
    }
    
    @Override
    public void onRestart()
    {
    	super.onRestart();
    	System.out.println("onRestart()");    	    	    	
    }
    
    @Override
    public void onResume()
    {
    	super.onResume();
    	System.out.println("onResume()");    	
    }
    
    @Override
    public void onPause()
    {
    	super.onPause();
    	System.out.println("onPause()");    	
    }

    @Override
    public void onStop()
    {
    	super.onStop();
    	System.out.println("onStop()");    	
    }

    @Override
    public void onDestroy()
    {
    	super.onDestroy();
    	System.out.println("onDestroy()");    	
    }

    
    @Override
    public void onSaveInstanceState(Bundle b)
    {
    	b.putString("VALUE", "HERE I AM");
    	System.out.println("onSaveInstanceState()");    	
    }
	@Override
	public boolean onCreateOptionsMenu(Menu menu) {
		// Inflate the menu; this adds items to the action bar if it is present.
		getMenuInflater().inflate(R.menu.main, menu);
		return true;
	}

}

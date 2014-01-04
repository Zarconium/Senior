package com.example.telephonydemo;

import android.app.Activity;
import android.content.Intent;
import android.net.Uri;
import android.os.Bundle;
import android.view.View;
import android.widget.EditText;

public class MainActivity extends Activity 
{
    @Override
    public void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.message);
    }
    
    public void call(View view)
    {
    	// add to call
    	Intent dial = new Intent(Intent.ACTION_CALL);
    	
    	EditText phone = (EditText) findViewById(R.id.phone);
    	String phoneNumber = phone.getText().toString();

    	dial.setData(Uri.parse("tel:"+phoneNumber) ); 
    	startActivity(dial); 
    }
    
    public void cancel(View view)
    {
    	finish();
    }
    
}

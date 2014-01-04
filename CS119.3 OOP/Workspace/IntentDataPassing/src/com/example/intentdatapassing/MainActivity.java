package com.example.intentdatapassing;

import android.app.Activity;
import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.view.View.OnClickListener;
import android.widget.Button;
import android.widget.TextView;

public class MainActivity extends Activity {
	
	public static final int INPUT_NAME = 0;
	public static final int INPUT_PHONE = 1;
	
    /** Called when the activity is first created. */
    @Override
    public void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        
        Button inputName = (Button) findViewById(R.id.button1);
        inputName.setOnClickListener(new OnClickListener() 
        {		
			public void onClick(View v) 
			{
				openInput(INPUT_NAME, "Name");
			}
		});
        
        Button inputPhone = (Button) findViewById(R.id.button2);
        inputPhone.setOnClickListener(new OnClickListener() 
        {
			public void onClick(View v) 
			{
				openInput(INPUT_PHONE, "Phone Number");
			}
		});
    }
    
    private void openInput(int requestCode, String label)
    {
    	Intent intent = new Intent(this, InputActivity.class);
    	intent.putExtra(InputActivity.LABEL, label);
    	startActivityForResult(intent, requestCode);
    }
    
    public void onActivityResult(int requestCode, int resultCode, Intent data)
    {
    	if (resultCode == InputActivity.CANCEL_PRESSED)
    	{
    		System.out.println("CANCEL PRESSED");
    	}
    	else
    	{
    		TextView textView;
    		String value = data.getStringExtra(InputActivity.INPUTTED_TEXT);
    		switch (requestCode)
    		{
    			case INPUT_NAME:
    				textView = (TextView) findViewById(R.id.textView2);
    				textView.setText(value);
    				break;
    				
    			case INPUT_PHONE:
    				textView = (TextView) findViewById(R.id.textView4);
    				textView.setText(value);
    				break;
    		}
    	}
    }
}
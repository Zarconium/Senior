package com.example.intentdatapassing;

import android.app.Activity;
import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.view.View.OnClickListener;
import android.widget.Button;
import android.widget.EditText;
import android.widget.TextView;

public class InputActivity extends Activity {
	
	public static final String LABEL = "LABEL";
	public static final String INPUTTED_TEXT = "INPUTTED_TEXT";
	public static final int DONE_PRESSED = 0;
	public static final int CANCEL_PRESSED = 1;
	
    /** Called when the activity is first created. */
    @Override
    public void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_input);
        
        
        TextView label = (TextView) findViewById(R.id.textView1);

        Intent intent = getIntent();
        label.setText(intent.getStringExtra(LABEL));
        
        
        
        Button done = (Button) findViewById(R.id.button1);
        done.setOnClickListener(new OnClickListener() {
			
			public void onClick(View v) 
			{
				close(DONE_PRESSED);
			}
		});
        
        Button cancel = (Button) findViewById(R.id.button2);
        cancel.setOnClickListener(new OnClickListener() {
			
			public void onClick(View v) 
			{
				close(CANCEL_PRESSED);				
			}
		});

    }
    
    private void close(int resultCode)
    {
    	Intent data = getIntent();
    	
        EditText textField = (EditText) findViewById(R.id.editText1);
    	data.putExtra(INPUTTED_TEXT, textField.getText().toString());
    	
    	setResult(resultCode, data);
    	finish();
    }
}
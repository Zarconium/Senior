package com.example.lab1_101047;

import android.app.Dialog;
import android.content.*;
import android.os.Bundle;
import android.view.*;
import android.widget.*;

public class HobbiesDialog extends Dialog
{
	public HobbiesDialog(Context context) {
		super(context);
	}

	@Override
	public void onCreate(Bundle savedInstanceState) 
	{
		super.onCreate(savedInstanceState);
		requestWindowFeature(Window.FEATURE_NO_TITLE);  

		setContentView(R.layout.activity_hobbies);
		
		setOnCancelListener(new OnCancelListener() 
		{
			@Override
			public void onCancel(DialogInterface arg0) 
			{
				
			}
		});
		
		Button b = (Button) findViewById(R.id.button1);
		b.setOnClickListener(new View.OnClickListener() {
			
			@Override
			public void onClick(View v)
			{
				dismiss();
			}
		});			
	}
	
}

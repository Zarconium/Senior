package com.example.lab4_101047;

import android.app.Dialog;
import android.content.*;
import android.os.Bundle;
import android.view.*;
import android.widget.*;

public class MovieDialog extends Dialog
{
	public MovieDialog(Context context)
	{
		super(context);
	}

	@Override
	public void onCreate(Bundle savedInstanceState) 
	{
		super.onCreate(savedInstanceState);
		requestWindowFeature(Window.FEATURE_NO_TITLE);  

		setContentView(R.layout.movie_dialog);
		
		setOnCancelListener(new OnCancelListener() 
		{
			@Override
			public void onCancel(DialogInterface arg0) 
			{
				
			}
		});
		
		Button b = (Button) findViewById(R.id.button1);
		b.setOnClickListener(new View.OnClickListener()
		{	
			@Override
			public void onClick(View v)
			{
				dismiss();
			}
		});			
	}
	
}

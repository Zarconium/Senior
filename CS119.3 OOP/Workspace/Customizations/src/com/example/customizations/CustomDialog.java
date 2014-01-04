package com.example.customizations;

import android.app.Dialog;
import android.content.Context;
import android.content.DialogInterface;
import android.os.Bundle;
import android.view.View;
import android.view.Window;
import android.widget.Button;
import android.widget.TextView;
import android.widget.Toast;

public class CustomDialog extends Dialog
{

	public CustomDialog(Context context) {
		super(context);
	}

	@Override
	public void onCreate(Bundle savedInstanceState) 
	{
		super.onCreate(savedInstanceState);
		// must be called before
		requestWindowFeature(Window.FEATURE_NO_TITLE);  

		setContentView(R.layout.custom_dialog);
	
		
		TextView text = (TextView) findViewById(R.id.textView1);
		text.setText("CUSTOM DIALOG");
		
		setOnDismissListener(new OnDismissListener() 
		{
			@Override
			public void onDismiss(DialogInterface arg0) 
			{
				Toast.makeText(getContext(), "DISMISSED", Toast.LENGTH_LONG).show();
			}
		});
		
		setOnCancelListener(new OnCancelListener() 
		{
			@Override
			public void onCancel(DialogInterface arg0) 
			{
				Toast.makeText(getContext(), "CANCELLED", Toast.LENGTH_LONG).show();
			}
		});
	
		
		// android:onClick does not work for Dialogs
		Button b = (Button) findViewById(R.id.button1);
		b.setOnClickListener(new View.OnClickListener() {
			
			@Override
			public void onClick(View v) {
				// TODO Auto-generated method stub
				dismiss();
			}
		});			
	}
	
}

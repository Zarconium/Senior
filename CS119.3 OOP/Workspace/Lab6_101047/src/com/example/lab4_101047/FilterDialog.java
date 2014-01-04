package com.example.lab4_101047;

import android.app.Dialog;
import android.content.*;
import android.os.Bundle;
import android.view.*;

public class FilterDialog extends Dialog
{
	public FilterDialog(Context context)
	{
		super(context);
	}

	@Override
	public void onCreate(Bundle savedInstanceState) 
	{
		super.onCreate(savedInstanceState);
		requestWindowFeature(Window.FEATURE_NO_TITLE);  

		setContentView(R.layout.filter_dialog);		
	}
	
}

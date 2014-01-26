package com.example.lab1_101047;

import android.os.Bundle;
import android.app.Activity;
import android.app.AlertDialog;
import android.content.DialogInterface;
import android.view.*;
import android.widget.TextView;

public class DataActivity extends Activity {

	@Override
	protected void onCreate(Bundle savedInstanceState) {
		super.onCreate(savedInstanceState);
		setContentView(R.layout.activity_data);
		
		String data = "Name:\n" + getIntent().getStringExtra("name") + 
				"\n\nAddress:\n" + getIntent().getStringExtra("address") + 
				"\n\nGender:\n" + getIntent().getStringExtra("gender") + 
				"\n\nBirthday:\n" + getIntent().getStringExtra("birthday") + 
				"\n\nHobbies:\n" + getIntent().getStringExtra("hobbies");
		
		TextView tv = (TextView) findViewById(R.id.textViewData);
		tv.setText(data);
	}

	@Override
	public boolean onCreateOptionsMenu(Menu menu) {
		// Inflate the menu; this adds items to the action bar if it is present.
		getMenuInflater().inflate(R.menu.data, menu);
		return true;
	}

	@Override
	public boolean onOptionsItemSelected(MenuItem item)
	{
		switch (item.getItemId())
		{
		case R.id.menu_previous:
			finish();
			break;
		case R.id.menu_exit:
			AlertDialog.Builder builder = new AlertDialog.Builder(this);
			builder.setMessage("Are you sure you want to exit?")
			       .setCancelable(false)
			       .setPositiveButton("Yes", new DialogInterface.OnClickListener() {
			           public void onClick(DialogInterface dialog, int id) 
			           {
					        finish();
			           }
			       })
			       .setNegativeButton("No", new DialogInterface.OnClickListener() {
			           public void onClick(DialogInterface dialog, int id) 
			           {
					        
			           }
			       });
			AlertDialog alert = builder.show();
			alert.show();
			break;
		}
		return false;
	}
	
	public void onBackPressed()
	{
		super.onBackPressed();
	}
}

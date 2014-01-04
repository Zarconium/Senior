package com.example.lab1_101047;

import android.os.Bundle;
import android.app.Activity;
import android.app.AlertDialog;
import android.content.*;
import android.view.*;
import android.widget.*;

public class MainActivity extends Activity {

	SharedPreferences prefs;
	
	@Override
	protected void onCreate(Bundle savedInstanceState) {
		super.onCreate(savedInstanceState);
		setContentView(R.layout.activity_main);
		
		prefs = getSharedPreferences("lab2_data", MODE_PRIVATE);
		String name = prefs.getString("name", null);
		String address = prefs.getString("address", null);
		
		if(name != null)
		{
			EditText et = (EditText) findViewById(R.id.editTextName);
			et.setText(name);
		}
		if(address != null)
		{
			EditText et = (EditText) findViewById(R.id.editTextAddress);
			et.setText(address);
		}
	}

	@Override
	public boolean onCreateOptionsMenu(Menu menu) {
		// Inflate the menu; this adds items to the action bar if it is present.
		getMenuInflater().inflate(R.menu.main, menu);
		return true;
	}

	@Override
	public boolean onOptionsItemSelected(MenuItem item)
	{
		switch (item.getItemId())
		{
		case R.id.menu_next:
			EditText etName = (EditText) findViewById(R.id.editTextName);
			String name = etName.getText().toString();
			EditText etAddress = (EditText) findViewById(R.id.editTextAddress);
			String address = etAddress.getText().toString();
			
			if (name.length() <= 0)
			{
				Toast.makeText(this, "Name must not be empty", Toast.LENGTH_SHORT).show();
			}
			else if (address.length() <= 0)
			{
				Toast.makeText(this, "Address must not be empty", Toast.LENGTH_SHORT).show();
			}
			else
			{
				Intent intent = new Intent(this, InputActivity.class);
				intent.putExtra("name", name);
				intent.putExtra("address", address);
				startActivity(intent);
			}
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
		
		SharedPreferences.Editor editor = prefs.edit();
		
		EditText et = (EditText) findViewById(R.id.editTextName);
		String name = et.getText().toString();
		et = (EditText) findViewById(R.id.editTextAddress);
		String address = et.getText().toString();
		
		editor.putString("name", name);
		editor.putString("address", address);
		
		editor.commit();
	}
}
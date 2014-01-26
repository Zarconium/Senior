package com.example.lab1_101047;

import android.os.Bundle;
import android.app.Activity;
import android.content.*;
import android.view.*;
import android.widget.*;

public class MainActivity extends Activity {

	@Override
	protected void onCreate(Bundle savedInstanceState) {
		super.onCreate(savedInstanceState);
		setContentView(R.layout.activity_main);
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
			
			Intent intent = new Intent(this, InputActivity.class);
			intent.putExtra("name", name);
			intent.putExtra("address", address);
			startActivity(intent);
			break;
		case R.id.menu_exit:
			finish();
			break;
		}
		return false;
	}
	
	public void onBackPressed()
	{
		finish();
	}
}

package com.example.lab1_101047;

import android.os.Bundle;
import android.app.Activity;
import android.content.*;
import android.view.*;
import android.widget.EditText;

public class BirthdayActivity extends Activity {

	public final static int DONE_PRESSED = 0;
	public final static int CANCEL_PRESSED = 1;
	public final static String BIRTHDAY = "";
	
	@Override
	protected void onCreate(Bundle savedInstanceState) {
		super.onCreate(savedInstanceState);
		setContentView(R.layout.activity_birthday);
		
		String birthday = getIntent().getStringExtra("birthday");
		
		if (!birthday.equalsIgnoreCase("Not Set"))
		{
			String birthday_split[] = birthday.split("/");
			
			EditText et = (EditText) findViewById(R.id.editTextDay);
			et.setText(birthday_split[0]);
			et = (EditText) findViewById(R.id.editTextMonth);
			et.setText(birthday_split[1]);
			et = (EditText) findViewById(R.id.editTextYear);
			et.setText(birthday_split[2]);
		}
	}

	@Override
	public boolean onCreateOptionsMenu(Menu menu) {
		// Inflate the menu; this adds items to the action bar if it is present.
		getMenuInflater().inflate(R.menu.birthday, menu);
		return true;
	}

	@Override
	public boolean onOptionsItemSelected(MenuItem item)
	{
		switch (item.getItemId())
		{
			case R.id.menu_done:
				close(DONE_PRESSED);
				break;
				
			case R.id.menu_cancel:
				close(CANCEL_PRESSED);
				break;
		}
		return false;
	}
	
	private void close(int resultCode)
	{
		Intent data = getIntent();
		String birthday = "";
		
		EditText etDay = (EditText) findViewById(R.id.editTextDay);
		birthday += etDay.getText().toString() + "/";
		EditText etMonth = (EditText) findViewById(R.id.editTextMonth);
		birthday += etMonth.getText().toString() + "/";
		EditText etYear = (EditText) findViewById(R.id.editTextYear);
		birthday += etYear.getText().toString();
		
		data.putExtra(BIRTHDAY, birthday);
		
		if(etDay.getText().toString().length() == 0 || etMonth.getText().toString().length() == 0 || etYear.getText().toString().length() == 0)
		{
			setResult(CANCEL_PRESSED, data);
		}
		else
		{
			setResult(resultCode, data);
		}
		finish();
	}
	
	public void onBackPressed()
	{
		close(CANCEL_PRESSED);
	}
	
}

package com.example.lab1_101047;

import java.util.*;

import android.os.Bundle;
import android.app.Activity;
import android.app.AlertDialog;
import android.app.DatePickerDialog;
import android.app.Dialog;
import android.app.DatePickerDialog.OnDateSetListener;
import android.content.DialogInterface;
import android.content.Intent;
import android.view.*;
import android.widget.*;

public class InputActivity extends Activity {

	@Override
	protected void onCreate(Bundle savedInstanceState) {
		super.onCreate(savedInstanceState);
		setContentView(R.layout.activity_input);
	}

	@Override
	public boolean onCreateOptionsMenu(Menu menu) {
		// Inflate the menu; this adds items to the action bar if it is present.
		getMenuInflater().inflate(R.menu.input, menu);
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
		case R.id.menu_next:
			RadioGroup radioGroup = (RadioGroup) findViewById(R.id.radioGroupGender);
			RadioButton gender = (RadioButton) findViewById(radioGroup.getCheckedRadioButtonId());
			TextView birthday = (TextView) findViewById(R.id.textViewBirthday);
			TextView hobbies = (TextView) findViewById(R.id.textViewHobbies);
			
			Intent intent = new Intent(this, DataActivity.class);
			intent.putExtras(getIntent());
			intent.putExtra("gender", gender.getText().toString());
			intent.putExtra("birthday", birthday.getText().toString());
			intent.putExtra("hobbies", hobbies.getText().toString());
			startActivity(intent);
			break;
		}
		return false;
	}
	
	public void buttonSet_click(View view)
	{
		/*TextView tv = (TextView) findViewById(R.id.textViewBirthday);
		Intent intent = new Intent(this, BirthdayActivity.class);
		intent.putExtra("birthday", tv.getText().toString());
		startActivityForResult(intent, 0);*/
		
		Calendar cal = Calendar.getInstance();
		Dialog d;
		OnDateSetListener dateCallBack = new OnDateSetListener()
		{	
			@Override
			public void onDateSet(DatePicker view, int year, int month, int day)
			{
				TextView tv = (TextView) findViewById(R.id.textViewBirthday);
				tv.setText(day + "/" + month + "/" + year);
			}
		};
		
		int year = cal.get(Calendar.YEAR);
		int monthOfYear = cal.get(Calendar.MONTH);
		int dayOfMonth = cal.get(Calendar.DAY_OF_MONTH);
		
		d = new DatePickerDialog(this, dateCallBack, year, monthOfYear, dayOfMonth);
		d.show();
	}
	
	public void buttonAddHobbies_click(View view)
	{
		/*TextView tv = (TextView) findViewById(R.id.textViewHobbies);
		Intent intent = new Intent(this, HobbiesActivity.class);
		intent.putExtra("hobbies", tv.getText().toString());
		startActivityForResult(intent, 1);*/
		
		final CharSequence[] items = {"Computer Games", "Movies", "Books", "Anime"};
		final boolean[] select = {false, false, false, false};
		
		AlertDialog.Builder builder = new AlertDialog.Builder(this);
		builder.setTitle("Pick hobbies");
		builder.setMultiChoiceItems(items, select, new DialogInterface.OnMultiChoiceClickListener()
		{
			@Override
			public void onClick(DialogInterface dialog, int which, boolean isChecked)
			{
				TextView tv = (TextView) findViewById(R.id.textViewHobbies);
				tv.setText("");
			}
		});
		
		AlertDialog alert = builder.show();
		alert.show();
	}
	
	/*public void onActivityResult(int requestCode, int resultCode, Intent data)
	{
		if (requestCode == 0)
		{
			if (resultCode == BirthdayActivity.DONE_PRESSED)
			{
				TextView tv = (TextView) findViewById(R.id.textViewBirthday);
				tv.setText(data.getStringExtra(BirthdayActivity.BIRTHDAY));
			}
		}
		else if (requestCode == 1)
		{
			if (resultCode == HobbiesActivity.DONE_PRESSED)
			{
				TextView tv = (TextView) findViewById(R.id.textViewHobbies);
				tv.setText(data.getStringExtra(HobbiesActivity.HOBBIES));
			}
		}
	}*/
	
	public void onBackPressed()
	{
		finish();
	}
}

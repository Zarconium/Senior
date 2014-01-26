package com.example.lab1_101047;

import java.util.*;

import android.os.Bundle;
import android.app.*;
import android.app.DatePickerDialog.*;
import android.content.*;
import android.content.DialogInterface.OnDismissListener;
import android.view.*;
import android.widget.*;

public class InputActivity extends Activity {

	SharedPreferences prefs;
	
	@Override
	protected void onCreate(Bundle savedInstanceState) {
		super.onCreate(savedInstanceState);
		setContentView(R.layout.activity_input);
		
		prefs = getSharedPreferences("lab2_data", MODE_PRIVATE);
		String gender = prefs.getString("gender", null);
		String birthday = prefs.getString("birthday", null);
		String hobbies = prefs.getString("hobbies", null);
		
		if(gender != null)
		{
			if(gender.equalsIgnoreCase("male"))
			{
				RadioButton r = (RadioButton) findViewById(R.id.radioMale);
				r.setChecked(true);
			}
			else if(gender.equalsIgnoreCase("female"))
			{
				RadioButton r = (RadioButton) findViewById(R.id.radioFemale);
				r.setChecked(true);
			}
		}
		if(birthday != null)
		{
			TextView tv = (TextView) findViewById(R.id.textViewBirthday);
			tv.setText(birthday);
		}
		if(hobbies != null)
		{
			TextView tv = (TextView) findViewById(R.id.textViewHobbies);
			tv.setText(hobbies);
		}
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
		final HobbiesDialog h = new HobbiesDialog(this);
		h.show();

		h.setOnDismissListener(new OnDismissListener() 
		{
			@Override
			public void onDismiss(DialogInterface arg0) 
			{
				CheckBox computerGames = (CheckBox) h.findViewById(R.id.checkBoxComputerGames);
				CheckBox movies = (CheckBox) h.findViewById(R.id.checkBoxMovies);
				CheckBox books = (CheckBox) h.findViewById(R.id.checkBoxBooks);
				CheckBox anime = (CheckBox) h.findViewById(R.id.checkBoxAnime);
				String hobbies = "";
				
				if (computerGames.isChecked())
				{
					hobbies += "Computer Games, ";
				}
				
				if (movies.isChecked())
				{
					hobbies += "Movies, ";
				}
				
				if (books.isChecked())
				{
					hobbies += "Books, ";
				}
				
				if (anime.isChecked())
				{
					hobbies += "Anime, ";
				}
				
				if (hobbies.length() > 0)
				{
					hobbies = hobbies.substring(0, hobbies.length() - 2);
				}
				else
				{
					hobbies = "None";
				}
				
				TextView tv = (TextView) findViewById(R.id.textViewHobbies);
				tv.setText(hobbies);
			}
		});
	}
	
	public void onBackPressed()
	{
		super.onBackPressed();
		
		SharedPreferences.Editor editor = prefs.edit();
		
		RadioGroup radioGroup = (RadioGroup) findViewById(R.id.radioGroupGender);
		RadioButton radioButton = (RadioButton) findViewById(radioGroup.getCheckedRadioButtonId());
		String gender = radioButton.getText().toString();
		TextView tv = (TextView) findViewById(R.id.textViewBirthday);
		String birthday = tv.getText().toString();
		tv = (TextView) findViewById(R.id.textViewHobbies);
		String hobbies = tv.getText().toString();
		
		editor.putString("gender", gender);
		editor.putString("birthday", birthday);
		editor.putString("hobbies", hobbies);
		
		editor.commit();
	}
}
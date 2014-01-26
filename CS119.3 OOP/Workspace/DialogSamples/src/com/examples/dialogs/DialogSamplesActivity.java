package com.examples.dialogs;

import java.util.Calendar;

import android.app.Activity;
import android.app.AlertDialog;
import android.app.DatePickerDialog;
import android.app.DatePickerDialog.OnDateSetListener;
import android.app.Dialog;
import android.app.TimePickerDialog;
import android.app.TimePickerDialog.OnTimeSetListener;
import android.content.DialogInterface;
import android.os.Bundle;
import android.view.View;
import android.widget.DatePicker;
import android.widget.TimePicker;
import android.widget.Toast;

public class DialogSamplesActivity extends Activity {
	
    /** Called when the activity is first shown. */
    @Override
    public void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.main);
    } 
    

	public void showAlertDialog1(View view) 
	{
		AlertDialog.Builder builder = new AlertDialog.Builder(this);
		builder.setMessage("Press a button?")
		       .setCancelable(false)
		       .setPositiveButton("Left", new DialogInterface.OnClickListener() {
		           public void onClick(DialogInterface dialog, int id) 
		           {
				        Toast.makeText(getApplicationContext(), "PRESSED LEFT", Toast.LENGTH_SHORT).show();
		           }
		       })
		       .setNegativeButton("Right", new DialogInterface.OnClickListener() {
		           public void onClick(DialogInterface dialog, int id) 
		           {
				        Toast.makeText(getApplicationContext(), "PRESSED RIGHT", Toast.LENGTH_SHORT).show();
		           }
		       });
		AlertDialog alert = builder.show();
		alert.show();
	}

	public void showAlertDialog2(View view) {
		final CharSequence[] items = {"Red", "Green", "Blue"};

		AlertDialog.Builder builder = new AlertDialog.Builder(this);
		builder.setTitle("Pick a color");
		builder.setItems(items, new DialogInterface.OnClickListener() {
		    public void onClick(DialogInterface dialog, int item) 
		    {
		        Toast.makeText(getApplicationContext(), items[item], Toast.LENGTH_SHORT).show();
		    }
		});
		AlertDialog alert = builder.show();
		alert.show();
	}

	public void showAlertDialog3(View view) {
		final CharSequence[] items = {"Red", "Green", "Blue"};

		AlertDialog.Builder builder = new AlertDialog.Builder(this);
		builder.setTitle("Pick a color");
		builder.setSingleChoiceItems(items, -1, new DialogInterface.OnClickListener() {
		    public void onClick(DialogInterface dialog, int item) {
		        Toast.makeText(getApplicationContext(), items[item], Toast.LENGTH_SHORT).show();
		    }
		});
		AlertDialog alert = builder.show();		
		alert.show();
	}

	public void showAlertDialog4(View view) {
		final CharSequence[] items = {"Red", "Green", "Blue"};
		final boolean[] select = {true, false, true};

		AlertDialog.Builder builder = new AlertDialog.Builder(this);
		builder.setTitle("Pick a color");
		builder.setMultiChoiceItems(items, select, new DialogInterface.OnMultiChoiceClickListener() {
			
			@Override
			public void onClick(DialogInterface dialog, int which, boolean isChecked) 
			{
		        Toast.makeText(getApplicationContext(), items[which], Toast.LENGTH_SHORT).show();
			}
		});
		AlertDialog alert = builder.show();		
		alert.show();
	}

	public void showTimeDialog(View view) 
	{
		Calendar cal = Calendar.getInstance();
		Dialog d;
		OnTimeSetListener timeCallBack = new OnTimeSetListener() 
		{
			@Override
			public void onTimeSet(TimePicker view, int hour, int minute)
			{
				System.out.println(hour+":"+minute);
			}
		};

		int hour = cal.get(Calendar.HOUR_OF_DAY);
		int minute = cal.get(Calendar.MINUTE);
		d = new TimePickerDialog(this, timeCallBack, hour, minute, true);
		d.show();
	}

	public void showDateDialog(View view) 
	{
		Calendar cal = Calendar.getInstance();
		Dialog d;
		OnDateSetListener dateCallBack = new OnDateSetListener() 
		{
			@Override
			public void onDateSet(DatePicker view, int year, int monthOfYear,
					int dayOfMonth) 
			{
				System.out.println(monthOfYear+"/"+dayOfMonth+"/"+year);
			}
		};

		int year = cal.get(Calendar.YEAR);
		int monthOfYear = cal.get(Calendar.MONTH);
		int dayOfMonth = cal.get(Calendar.DAY_OF_MONTH);
		d = new DatePickerDialog(this, 
								 dateCallBack, 
								 year, 
								 monthOfYear, 
								 dayOfMonth);
		d.show();
	}

}
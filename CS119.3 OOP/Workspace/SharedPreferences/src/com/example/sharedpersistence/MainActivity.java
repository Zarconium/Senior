package com.example.sharedpersistence;

import android.app.Activity;
import android.content.SharedPreferences;
import android.os.Bundle;
import android.view.View;
import android.widget.TextView;

public class MainActivity extends Activity {

	@Override
	protected void onCreate(Bundle savedInstanceState) {
		super.onCreate(savedInstanceState);
		setContentView(R.layout.activity_main);
		
		TextView textView = (TextView) findViewById(R.id.textview1);
		
		SharedPreferences prefs = getSharedPreferences("my_data", MODE_PRIVATE);
		String saved = prefs.getString("saved", null);
		if (saved==null)
		{
			textView.setText("Nothing saved");
		}
		else
		{
			textView.setText(saved);
		}		
	}
	
	public void onBackPressed()
	{
		super.onBackPressed();
		
		SharedPreferences prefs = getSharedPreferences("my_data", MODE_PRIVATE);
		SharedPreferences.Editor editor = prefs.edit();
		
		editor.putString("saved","Stuff I saved on back");
		
		editor.commit();
		
		
	}
	
	public void clearPrefs(View view)
	{
		SharedPreferences prefs = getSharedPreferences("my_data", MODE_PRIVATE);
		SharedPreferences.Editor editor = prefs.edit();
		editor.clear();
		editor.commit();
		
		finish();
	}
}

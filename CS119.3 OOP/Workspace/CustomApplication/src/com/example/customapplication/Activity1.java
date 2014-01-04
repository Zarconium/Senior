package com.example.customapplication;

import android.app.Activity;
import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.TextView;

public class Activity1 extends Activity {

	@Override
	protected void onCreate(Bundle savedInstanceState) {
		super.onCreate(savedInstanceState);
		setContentView(R.layout.activity_main);
		
		
		TextView textView = (TextView) findViewById(R.id.textView1);
		CustomApplication app = (CustomApplication) getApplication();
		textView.setText(app.getCustomData());
	}

	public void nextActivity(View v)
	{
		CustomApplication app = (CustomApplication) getApplication();
		app.setCustomData("Just left Activity 1");
		
		Intent intent = new Intent(this, Activity2.class);
		startActivity(intent);
		
		finish();

	}
	
}

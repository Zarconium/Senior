package com.example.scrollviewtest;

import android.os.Bundle;
import android.app.Activity;
import android.view.Menu;
import android.widget.ScrollView;

public class MainActivity extends Activity {

	@Override
	protected void onCreate(Bundle savedInstanceState) {
		super.onCreate(savedInstanceState);
		setContentView(R.layout.activity_main);
		
		ScrollView scrollView = (ScrollView) findViewById(R.id.ScrollView1);
		
		
		// override the default settings
		scrollView.setScrollbarFadingEnabled(false);
		scrollView.setHorizontalScrollBarEnabled(true);
		scrollView.setVerticalScrollBarEnabled(true);
	}

	@Override
	public boolean onCreateOptionsMenu(Menu menu) {
		// Inflate the menu; this adds items to the action bar if it is present.
		getMenuInflater().inflate(R.menu.main, menu);
		return true;
	}

}

package com.example.buttonmenusample;

import android.app.Activity;
import android.os.Bundle;
import android.view.Menu;
import android.view.MenuItem;
import android.view.View;
import android.view.View.OnClickListener;
import android.widget.Button;
import android.widget.TextView;
import android.widget.Toast;

public class MainActivity extends Activity {

	private TextView textView;

	@Override
	protected void onCreate(Bundle savedInstanceState) {
		super.onCreate(savedInstanceState);
		setContentView(R.layout.activity_main);

		textView = (TextView) findViewById(R.id.textView1);

		initButton1WithListener();
	}
	
	// BUTTON HANDLING

	private void initButton1WithListener()
	{
		Button button1 = (Button) findViewById(R.id.button1);
		button1.setOnClickListener(new OnClickListener() {

			@Override
			public void onClick(View v) {
				textView.setText("Button 1 pressed");

			}
		});		
	}

	public void button2Click(View view) {
		switch (view.getId()) {
		case R.id.button2a:
			textView.setText("Button 2a pressed");
			break;

		case R.id.button2b:
			textView.setText("Button 2b pressed");
			break;

		}
	}

	
	// MENU HANDLING
	
	@Override
	public boolean onCreateOptionsMenu(Menu menu) {
		// Inflate the menu; this adds items to the action bar if it is present.
		getMenuInflater().inflate(R.menu.activity_main, menu);
		return true;
	}

	@Override
     public boolean onOptionsItemSelected(MenuItem item) {
	   
		switch(item.getItemId())
	    {
	    case R.id.start:
			Toast.makeText(this, "Start", Toast.LENGTH_LONG).show();
		    break;    
	    case R.id.quit:
			Toast.makeText(this, "Quit", Toast.LENGTH_LONG).show();
		    break;
	    }
	           return true;
	    }

}

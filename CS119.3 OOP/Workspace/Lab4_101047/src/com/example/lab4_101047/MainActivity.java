package com.example.lab4_101047;

import android.os.Bundle;
import android.app.*;
import android.content.*;
import android.view.*;
import android.widget.TextView;

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

	public void onClick(View view)
	{
		Intent intent = new Intent(this, MovieListActivity.class);
		startActivityForResult(intent, 0);
	}
	
	public void onActivityResult(int requestCode, int resultCode, Intent data)
	{
		if (requestCode == 0)
		{
			if (resultCode == 0)
			{
				TextView tv = (TextView) findViewById(R.id.textViewMovie);
				tv.setText(data.getStringExtra("title"));
			}
		}
	}
}

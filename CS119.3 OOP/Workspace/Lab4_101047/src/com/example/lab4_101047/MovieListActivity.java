package com.example.lab4_101047;

import android.os.Bundle;
import android.app.*;
import android.content.*;
import android.view.*;
import android.widget.*;
import android.widget.AdapterView.OnItemClickListener;

public class MovieListActivity extends ListActivity {
	private String[] movies;
	
	@Override
	protected void onCreate(Bundle savedInstanceState) {
		super.onCreate(savedInstanceState);
		
		movies = getResources().getStringArray(R.array.movies_list);
		setListAdapter(new ArrayAdapter<String>(this, R.layout.list_item, movies));
		
		ListView lv = getListView();
		lv.setTextFilterEnabled(true);
		
		lv.setOnItemClickListener(new OnItemClickListener()
		{
			public void onItemClick(AdapterView<?> parent, View view, int position, long id)
			{
				Intent data = getIntent();
				data.putExtra("title", ((TextView) view).getText().toString());
				setResult(0, data);
				finish();
			}
		});
	}
	
	public void onBackPressed()
	{
		Intent data = getIntent();
		setResult(1, data);
		finish();
	}
}
package com.example.lab4_101047;

import java.util.ArrayList;

import android.os.Bundle;
import android.app.*;
import android.content.*;
import android.content.DialogInterface.*;
import android.view.*;
import android.view.ContextMenu.*;
import android.widget.*;
import android.widget.AdapterView.*;

public class MainActivity extends ListActivity
{
	private ArrayList<MovieData> movies;
	private CustomAdapter adapter;

	@Override
	protected void onCreate(Bundle savedInstanceState)
	{
		super.onCreate(savedInstanceState);

		movies = new ArrayList<MovieData>();
		String[] moviesArray = getResources().getStringArray(R.array.movies_list);
		
		for (String s : moviesArray)
		{
			String[] parsed = s.split(";");
			MovieData movie = new MovieData();
			movie.setTitle(parsed[0]);
			movie.setGross(parsed[1]);
			movie.setYear(parsed[2]);
			movies.add(movie);
		}
		
		adapter = new CustomAdapter(movies);
		setListAdapter(adapter);

		ListView lv = getListView();
		lv.setTextFilterEnabled(true);
		registerForContextMenu(lv);
	}
	
	@Override
	public void onCreateContextMenu(ContextMenu menu, View v, ContextMenuInfo menuInfo)
    {
    	super.onCreateContextMenu(menu, v, menuInfo);
		getMenuInflater().inflate(R.menu.main, menu);
	}
	
	@Override
	public boolean onContextItemSelected(MenuItem item)
	{
		final AdapterContextMenuInfo info = (AdapterContextMenuInfo) item.getMenuInfo();
		
		switch (item.getItemId())
		{
		case R.id.add:
			final MovieDialog add = new MovieDialog(this);
			add.show();
			
			add.setOnDismissListener(new OnDismissListener()
			{
				@Override
				public void onDismiss(DialogInterface dialog)
				{
					String title = ((EditText) add.findViewById(R.id.editTextTitle)).getText().toString();
					String gross = ((EditText) add.findViewById(R.id.editTextGross)).getText().toString();
					String year = ((EditText) add.findViewById(R.id.editTextYear)).getText().toString();
					
					MovieData movie = new MovieData();
					movie.setTitle(title);
					movie.setGross(gross);
					movie.setYear(year);
					
					movies.add(movie);
					adapter.notifyDataSetChanged();
				}
			});
			
			add.setOnCancelListener(new OnCancelListener()
			{
				@Override
				public void onCancel(DialogInterface arg0)
				{
					//Do nothing
				}
			});
			
			return true;
			
		case R.id.insert:
			final MovieDialog insert = new MovieDialog(this);
			insert.show();
			
			insert.setOnDismissListener(new OnDismissListener()
			{
				@Override
				public void onDismiss(DialogInterface dialog)
				{
					String title = ((EditText) insert.findViewById(R.id.editTextTitle)).getText().toString();
					String gross = ((EditText) insert.findViewById(R.id.editTextGross)).getText().toString();
					String year = ((EditText) insert.findViewById(R.id.editTextYear)).getText().toString();
					
					MovieData movie = new MovieData();
					movie.setTitle(title);
					movie.setGross(gross);
					movie.setYear(year);
					
					movies.add(info.position, movie);
					adapter.notifyDataSetChanged();
				}
			});
			
			insert.setOnCancelListener(new OnCancelListener()
			{
				@Override
				public void onCancel(DialogInterface arg0)
				{
					//Do nothing
				}
			});
			
			return true;
			
		case R.id.edit:
			final MovieDialog edit = new MovieDialog(this);
			edit.show();
			
			((EditText) edit.findViewById(R.id.editTextTitle)).setText(movies.get(info.position).getTitle());
			((EditText) edit.findViewById(R.id.editTextGross)).setText(movies.get(info.position).getGross());
			((EditText) edit.findViewById(R.id.editTextYear)).setText(movies.get(info.position).getYear());
			
			edit.setOnDismissListener(new OnDismissListener()
			{
				@Override
				public void onDismiss(DialogInterface dialog)
				{
					String title = ((EditText) edit.findViewById(R.id.editTextTitle)).getText().toString();
					String gross = ((EditText) edit.findViewById(R.id.editTextGross)).getText().toString();
					String year = ((EditText) edit.findViewById(R.id.editTextYear)).getText().toString();
					
					movies.get(info.position).setTitle(title);
					movies.get(info.position).setGross(gross);
					movies.get(info.position).setYear(year);
					
					adapter.notifyDataSetChanged();
				}
			});
			
			edit.setOnCancelListener(new OnCancelListener()
			{
				@Override
				public void onCancel(DialogInterface arg0)
				{
					//Do nothing
				}
			});
			
			return true;
			
		case R.id.delete:
			AlertDialog.Builder builder = new AlertDialog.Builder(this);
			
			builder.setMessage("Delete movie?");
			builder.setCancelable(false);
			builder.setPositiveButton("Yes", new DialogInterface.OnClickListener()
			{
				@Override
				public void onClick(DialogInterface dialog, int which)
				{
					movies.remove(info.position);
					adapter.notifyDataSetChanged();
				}
			});
			builder.setNegativeButton("No", new DialogInterface.OnClickListener()
			{
				@Override
				public void onClick(DialogInterface dialog, int which)
				{
					//Do nothing
				}
			});
			
			AlertDialog alert = builder.show();
			alert.show();
			
			return true;
			
		default:
			return super.onContextItemSelected(item);
		}
	}
	
	private class CustomAdapter extends BaseAdapter
	{
		private ArrayList<MovieData> internalList;
		
		public CustomAdapter(ArrayList<MovieData> movies)
		{
			internalList = movies;
		}

		@Override
		public int getCount()
		{
			return internalList.size();
		}

		@Override
		public Object getItem(int index)
		{
			return internalList.get(index);
		}

		@Override
		public long getItemId(int position)
		{
			return position;
		}

		@Override
		public View getView(int position, View convertView, ViewGroup parent)
		{
			LayoutInflater inflater = getLayoutInflater();
			View view;
			
			if (convertView == null)
			{
				view = inflater.inflate(R.layout.row, null);
			}
			else
			{
				view = convertView;
			}
			
			TextView title = (TextView) view.findViewById(R.id.textViewTitle);
			
			MovieData movie = this.internalList.get(position);
			
			title.setText(movie.getTitle());
			
			return view;
		}
	
	}
}
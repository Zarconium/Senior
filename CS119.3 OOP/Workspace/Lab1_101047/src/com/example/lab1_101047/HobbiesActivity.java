package com.example.lab1_101047;

import android.os.Bundle;
import android.app.Activity;
import android.content.Intent;
import android.view.*;
import android.widget.*;

public class HobbiesActivity extends Activity {

	public final static int DONE_PRESSED = 0;
	public final static int CANCEL_PRESSED = 1;
	public final static String HOBBIES = "";
	
	@Override
	protected void onCreate(Bundle savedInstanceState) {
		super.onCreate(savedInstanceState);
		setContentView(R.layout.activity_hobbies);
		
		String hobbies = getIntent().getStringExtra("hobbies");
		
		if (!hobbies.equalsIgnoreCase("Not set") && !hobbies.equalsIgnoreCase("None"))
		{
			String hobbies_split[] = hobbies.split(", ");
			
			for (int i = 0; i < hobbies_split.length; i++)
			{
				if (hobbies_split[i].equalsIgnoreCase("Computer Games"))
				{
					((CheckBox) findViewById(R.id.checkBoxComputerGames)).setChecked(true);
				}
				else if (hobbies_split[i].equalsIgnoreCase("Movies"))
				{
					((CheckBox) findViewById(R.id.checkBoxMovies)).setChecked(true);
				}
				else if (hobbies_split[i].equalsIgnoreCase("Books"))
				{
					((CheckBox) findViewById(R.id.checkBoxBooks)).setChecked(true);
				}
				else if (hobbies_split[i].equalsIgnoreCase("Anime"))
				{
					((CheckBox) findViewById(R.id.checkBoxAnime)).setChecked(true);
				}
			}
		}
	}

	@Override
	public boolean onCreateOptionsMenu(Menu menu) {
		// Inflate the menu; this adds items to the action bar if it is present.
		getMenuInflater().inflate(R.menu.hobbies, menu);
		return true;
	}

	@Override
	public boolean onOptionsItemSelected(MenuItem item)
	{
		switch (item.getItemId())
		{
		case R.id.menu_done:
			close(DONE_PRESSED);
			break;
		case R.id.menu_cancel:
			close(CANCEL_PRESSED);
			break;
		}
		return false;
	}
	
	public void close(int resultCode)
	{
		Intent data = getIntent();
		String hobbies = "";
		CheckBox computerGames = (CheckBox) findViewById(R.id.checkBoxComputerGames);
		CheckBox movies = (CheckBox) findViewById(R.id.checkBoxMovies);
		CheckBox books = (CheckBox) findViewById(R.id.checkBoxBooks);
		CheckBox anime = (CheckBox) findViewById(R.id.checkBoxAnime);
		
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
			data.putExtra(HOBBIES, hobbies);
			setResult(resultCode, data);
		}
		else
		{
			hobbies = "None";
			data.putExtra(HOBBIES, hobbies);
			setResult(resultCode, data);
		}
		
		finish();
	}
	
	public void onBackPressed()
	{
		close(CANCEL_PRESSED);
	}
}

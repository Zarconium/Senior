package com.example.sdcardaccess;

import java.io.BufferedReader;
import java.io.File;
import java.io.FileInputStream;
import java.io.FileOutputStream;
import java.io.InputStreamReader;
import java.io.OutputStreamWriter;
import java.io.PrintWriter;

import android.app.Activity;
import android.os.Bundle;
import android.os.Environment;
import android.widget.TextView;
import android.widget.Toast;

public class MainActivity extends Activity {

	@Override
	protected void onCreate(Bundle savedInstanceState) {
		super.onCreate(savedInstanceState);
		setContentView(R.layout.activity_main);
		
		
		TextView textView = (TextView) findViewById(R.id.textview1);

		try
		{
			File sdCard = Environment.getExternalStorageDirectory();
			File directory = new File (sdCard.getAbsolutePath() + "/sdcardtest/");
			directory.mkdirs();
			
			File file = new File(directory, "textfile2.txt");
			
			//  corresponds to <sd card root>/sdcardtest/textfile.txt

			if (file.exists())
			{
				FileInputStream fIn = new FileInputStream(file);
				InputStreamReader isr = new InputStreamReader(fIn);
				
				BufferedReader br = new BufferedReader(isr);
				Toast.makeText(this, br.readLine(), Toast.LENGTH_LONG).show();
				
				br.close();
				// read file
				textView.setText("read from "+file.getAbsolutePath());
			}
			else
			{
				FileOutputStream fOut = new FileOutputStream(file);
				OutputStreamWriter osr = new OutputStreamWriter(fOut);
				PrintWriter pw = new PrintWriter(osr);
				
				pw.println("Written stuff");

				pw.close();
				
				// write file
				textView.setText("wrote to "+file.getAbsolutePath());
			}	
		}
		catch(Exception e)
		{
			e.printStackTrace();
			textView.setText(e.getClass().getName());
		}
		
		
	}



}

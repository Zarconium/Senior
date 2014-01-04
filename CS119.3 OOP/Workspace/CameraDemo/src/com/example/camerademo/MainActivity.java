package com.example.camerademo;

import java.io.File;
import java.io.FileNotFoundException;
import java.io.InputStream;

import android.app.Activity;
import android.content.Intent;
import android.graphics.Bitmap;
import android.graphics.BitmapFactory;
import android.net.Uri;
import android.os.Bundle;
import android.os.Environment;
import android.provider.MediaStore;
import android.view.View;
import android.widget.ImageView;
import android.widget.TextView;

public class MainActivity extends Activity {

	private TextView textTargetUri;
	private ImageView targetImage;

	/** Called when the activity is first created. */
	@Override
	public void onCreate(Bundle savedInstanceState) {
		super.onCreate(savedInstanceState);
		setContentView(R.layout.activity_main);
		
		textTargetUri = (TextView) findViewById(R.id.targeturi);
		targetImage = (ImageView) findViewById(R.id.targetimage);
	}

	File outputFile;
	
	public void takePicture(View view)
	{
	
		File sdCard = Environment.getExternalStorageDirectory();
		File directory = new File (sdCard.getAbsolutePath() + "/CameraTest/");
		directory.mkdirs();
		
		// unique filename based on the time
		outputFile = new File(directory, System.currentTimeMillis()+".jpg");

        Uri outputFileUri = Uri.fromFile(outputFile);
        Intent intent = new Intent("android.media.action.IMAGE_CAPTURE");
        intent.putExtra(MediaStore.EXTRA_OUTPUT, outputFileUri);

        startActivityForResult(intent, 0);
	}
	
	@Override
	protected void onActivityResult(int requestCode, int resultCode, Intent data) {

		if (resultCode == RESULT_OK) 
		{
			// rescale the picture from the full size output file which is assumed to now be
			// in outputFile
			try
			{
				BitmapFactory.Options options = new BitmapFactory.Options();
				options.inSampleSize = 8;
				options.inDither = false;
				options.inPurgeable = true;
				
				Bitmap bitMap = BitmapFactory.decodeFile(outputFile.getAbsolutePath(), options);
				
				textTargetUri.setText(outputFile.getAbsolutePath());
				
				ImageView imageView = (ImageView) findViewById(R.id.targetimage);
	
				//bitMap = Bitmap.createScaledBitmap(bitMap, imageView.getWidth(), imageView.getHeight(), true);
				imageView.setImageBitmap(bitMap);
			}
			catch(Exception e)
			{
				textTargetUri.setText(e.getClass().getName());				
			}
		}
	}
}

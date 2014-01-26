package com.example.gallerydemo;

import java.io.FileNotFoundException;
import java.io.InputStream;

import android.app.Activity;
import android.content.Intent;
import android.graphics.Bitmap;
import android.graphics.BitmapFactory;
import android.net.Uri;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
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

	public void loadImage(View view)
	{
		
		// NOTE: either of these work
		
//		Intent intent = new Intent(
//				Intent.ACTION_PICK,
//				android.provider.MediaStore.Images.Media.EXTERNAL_CONTENT_URI);
		
    	Intent intent = new Intent();
    	intent.setType("image/*jpg");
    	intent.setAction(Intent.ACTION_GET_CONTENT);

		
		startActivityForResult(intent, 0);		
	}
	
	@Override
	protected void onActivityResult(int requestCode, int resultCode, Intent data) {

		if (resultCode == RESULT_OK) 
		{
			// the URI holds the location of the image 
			Uri targetUri = data.getData();
			textTargetUri.setText(targetUri.toString());
			Bitmap bitmap;
			
			try 
			{
				// pull out the image as a stream
				InputStream is = getContentResolver().openInputStream(targetUri);
				bitmap = BitmapFactory.decodeStream(is);
				targetImage.setImageBitmap(bitmap);
			} 
			catch (FileNotFoundException e) 
			{
				e.printStackTrace();
			}
		}
	}
}

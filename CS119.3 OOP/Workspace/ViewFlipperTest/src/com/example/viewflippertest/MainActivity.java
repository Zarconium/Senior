package com.example.viewflippertest;

import android.app.Activity;
import android.os.Bundle;
import android.view.View;
import android.widget.ViewFlipper;

public class MainActivity extends Activity {

	ViewFlipper soapFlipper;
	ViewFlipper consultationFlipper;
	
	@Override
	protected void onCreate(Bundle savedInstanceState) {
		super.onCreate(savedInstanceState);
		setContentView(R.layout.consultation_input_layout);
		
		consultationFlipper = (ViewFlipper) findViewById(R.id.consultationViewFlipper);
		soapFlipper = (ViewFlipper) findViewById(R.id.soapViewFlipper);
	}

	// CONSULTATIION
	
	public void consultationBack(View view)
	{
		if (consultationFlipper.getDisplayedChild()==0)
		{
		}
		else if (soapFlipper.getDisplayedChild()==0)
		{
			consultationFlipper.showPrevious();
		}
		else
		{
			soapFlipper.showPrevious();
		}
	}
	
	public void consultationNext(View view)
	{
		if (consultationFlipper.getDisplayedChild()==0)
		{
			consultationFlipper.showNext();
		}
		else
		{
			if (soapFlipper.getDisplayedChild()<soapFlipper.getChildCount()-1)
			{
				soapFlipper.showNext();
			}
		}
	}
	
	public void soapSubjectiveStart(View view)
	{
		soapFlipper.setDisplayedChild(0);
	}
	
	public void soapObjectiveStart(View view)
	{
		soapFlipper.setDisplayedChild(1);		
	}

	public void soapAssessmentStart(View view)
	{
		soapFlipper.setDisplayedChild(6);		
	}
	
	public void soapPlanStart(View view)
	{
		soapFlipper.setDisplayedChild(7);		
	}
}

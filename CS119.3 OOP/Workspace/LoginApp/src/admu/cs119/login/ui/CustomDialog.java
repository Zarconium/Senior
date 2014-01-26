package admu.cs119.login.ui;

import android.app.AlertDialog;
import android.app.Dialog;
import android.content.Context;
import android.content.DialogInterface;
import android.os.Bundle;
import android.view.View;

public class CustomDialog extends Dialog{

	public CustomDialog(Context context) 
	{
		super(context);
	}
	
	protected void onCreate(Bundle savedInstanceState)
	{
		super.onCreate(savedInstanceState);
		setCanceledOnTouchOutside(true);		
	}
	
	public final void cancel()
	{
		promptCancel();
	}
	
	public final void cancel(View v)
	{
		promptCancel();
	}
	
	@Override
	public final void onBackPressed()
	{
		// cancel
		promptCancel();
	}
	
	protected void precancel()
	{
		
	}
	
	public void promptCancel()
	{
		Dialog d = new AlertDialog.Builder(getContext())
        .setTitle("Do you wish to cancel?")
        .setPositiveButton("Yes",
                           new DialogInterface.OnClickListener()
                           {
                               @Override
                               public void onClick(DialogInterface dialog,
                                                   int whichButton)
                               {
                            	   precancel();
                            	   CustomDialog.super.cancel();
                               }
                           })
        .setNegativeButton("No",
                           new DialogInterface.OnClickListener()
                           {
                               @Override
                               public void onClick(DialogInterface dialog,
                                                   int whichButton)
                               {
                                   // do nothing
                            	   dialog.cancel();
                               }
                           }).create();
		
		d.show();
	}

}

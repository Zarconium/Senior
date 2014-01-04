package admu.cs119.login.validator;

import android.view.View;
import android.widget.EditText;

public class FocusWatcher implements View.OnFocusChangeListener
{

	private ValidationRule[] rules;

	public FocusWatcher()
	{
	}
	
	public FocusWatcher(ValidationRule... rules)
	{
		this.rules = rules;
	}

	@Override
	public void onFocusChange(View v, boolean hasFocus) 
	{
		try
		{
//			for (ValidationRule rule : rules)
//			{
//				rule.validate(v);
//			}
			
			if (v instanceof EditText)
			{
				EditText editText = (EditText) v;
				editText.setError(null);
			}
		}
		catch(RuntimeException e)
		{	
			e.printStackTrace();
		}
	}
}
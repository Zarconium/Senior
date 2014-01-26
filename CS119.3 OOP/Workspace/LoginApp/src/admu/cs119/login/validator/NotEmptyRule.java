package admu.cs119.login.validator;

import android.view.View;
import android.widget.EditText;
import android.widget.Spinner;

public class NotEmptyRule implements ValidationRule {

	private ValidationAction action;

	public NotEmptyRule()
	{
		
	}

	public NotEmptyRule(ValidationAction action)
	{
		this.action = action;
	}
	
	@Override
	public void validate(View v) 
	{
		if (v instanceof EditText)
		{
			EditText editText = (EditText) v;
			if (editText.getText().toString().length()==0)
			{
				v.requestFocus();
				if (action!=null)
				{
					action.onValidationFailed(v);
				}

				editText.setError("Cannot be empty");

				throw new RuntimeException();
			}
		}
		else if (v instanceof Spinner)
		{
			Spinner spinner = (Spinner) v;
			
			
			if (spinner.getSelectedItemPosition()==Spinner.INVALID_POSITION)
			{
				v.requestFocus();
				if (action!=null)
				{
					action.onValidationFailed(v);
				}
				throw new RuntimeException("Cannot be empty");
			}
			if (spinner.getSelectedItem().toString().equals(""))
			{
				v.requestFocus();
				if (action!=null)
				{
					action.onValidationFailed(v);
				}
				throw new RuntimeException("Cannot be empty");
			}
		}
		
	}


}

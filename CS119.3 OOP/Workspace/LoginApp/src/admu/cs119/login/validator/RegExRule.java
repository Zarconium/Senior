package admu.cs119.login.validator;

import android.view.View;
import android.widget.EditText;

public class RegExRule implements ValidationRule{
	
	private String regularExpression;
	private String message;
	private ValidationAction action;
	
	public RegExRule(String regEx, String message)
	{
		regularExpression = regEx;
		this.message = message;
	}

	public RegExRule(String regEx, String message, ValidationAction action)
	{
		regularExpression = regEx;
		this.message = message;
		this.action = action;
	}

	@Override
	public void validate(View v) 
	{
		if (v instanceof EditText)
		{
			EditText editText = (EditText) v;
			if (!editText.getText().toString().matches(regularExpression))
			{
				v.requestFocus();
				if (action!=null)
				{
					action.onValidationFailed(v);
				}
				editText.setError(message);
				throw new RuntimeException(message);
			}
		}
	}
}

package admu.cs119.login.validator;

import java.util.Arrays;
import java.util.List;

import android.view.View;
import android.widget.Spinner;

public class PrefixRule implements ValidationRule{
	
	private Spinner genderView;
	private String message;
	private ValidationAction action;
	
	public PrefixRule(Spinner dependentView)
	{
		this.genderView = dependentView;
	}

	public PrefixRule(Spinner dependentView, ValidationAction action)
	{
		this.genderView = dependentView;
		this.action = action;
	}

	private static List<String> allowedMalePrefix = Arrays.asList(new String[]{"Mr."});
	private static List<String> allowedFemalePrefix = Arrays.asList(new String[]{"Ms.","Mrs."});
	
	@Override
	public void validate(View v) 
	{
		if (v instanceof Spinner)
		{
			Spinner s = (Spinner) v;
			
			List<String> allowedValues;
			String gender = genderView.getSelectedItem().toString();
			if (gender.equals("Male"))
			{
				allowedValues = allowedMalePrefix;
			}
			else
			{
				allowedValues = allowedFemalePrefix;
			}

			if (!allowedValues.contains(s.getSelectedItem().toString()))
			{
				v.requestFocus();
				if (action!=null)
				{
					action.onValidationFailed(v);
				}
				throw new RuntimeException("A "+gender+" must be "+allowedValues);
			}
		}
	}
}

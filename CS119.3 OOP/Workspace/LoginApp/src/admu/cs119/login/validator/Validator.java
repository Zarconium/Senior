package admu.cs119.login.validator;

import java.util.LinkedHashMap;

import android.view.View;

public class Validator 
{
	private LinkedHashMap<View, ValidationRule[]> map = new LinkedHashMap<View, ValidationRule[]>();
	
	public void addViewForValidation(View view, final ValidationRule... rules)
	{
		if (rules.length==0)
		{
			return;
		}
		map.put(view, rules);
		
		
		// potentially use the focus watcher to handle validation as you input
		view.setOnFocusChangeListener(new FocusWatcher(rules));
	}

	public void validate()
	{
		for (View view : map.keySet())
		{
			ValidationRule[] rules = map.get(view);
			
			try
			{
				for (ValidationRule rule : rules)
				{
					rule.validate(view);
				}
			}
			catch(RuntimeException e)
			{
				throw e;
			}
		}
	}
}

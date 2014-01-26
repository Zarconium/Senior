package admu.cs119.login.validator;

import android.text.Editable;
import android.text.TextWatcher;
import android.widget.EditText;

public class RegExWatcher implements TextWatcher
{
	private EditText editText;
	private String regEx;
	
	public RegExWatcher(EditText editText) 
	{
		// TODO Auto-generated constructor stub
		this.editText = editText;
	}

	public RegExWatcher(EditText editText, String regEx) 
	{
		// TODO Auto-generated constructor stub
		this.editText = editText;
		this.regEx = regEx;
	}

	
	@Override
	public void onTextChanged(CharSequence s, int start, int before, int count) 
	{
	}
	
	@Override
	public void beforeTextChanged(CharSequence s, int start, int count,
			int after) 
	{
	}
	
	@Override
	public void afterTextChanged(Editable s) {
		// TODO Auto-generated method stub
		if (s.toString().length()==0)
		{
			editText.requestFocus();
			editText.setError(editText.getHint()+": Cannot be empty");
		}
		else if ((regEx!=null) && (!s.toString().matches(regEx)))
		{
			editText.requestFocus();
			editText.setError(editText.getHint()+": Invalid format");
		}

	}
}
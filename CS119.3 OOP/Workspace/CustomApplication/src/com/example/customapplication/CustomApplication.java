package com.example.customapplication;

import android.app.Application;

public class CustomApplication extends Application 
{
	private String customData;

	public String getCustomData() {
		return customData;
	}

	public void setCustomData(String customData) {
		this.customData = customData;
	}
	
	

}

package admu.cs119.login.service;

import java.io.BufferedReader;
import java.io.InputStream;
import java.io.InputStreamReader;
import java.net.URLEncoder;
import java.util.HashMap;
import java.util.Iterator;

import org.apache.http.HttpEntity;
import org.apache.http.HttpResponse;
import org.apache.http.client.methods.HttpGet;
import org.apache.http.client.methods.HttpPost;
import org.apache.http.entity.StringEntity;
import org.apache.http.impl.client.DefaultHttpClient;

public class NetUtil {

	private static DefaultHttpClient httpClient = new DefaultHttpClient();

	public static String appendTokenParams(String url, String token) 
	{
		StringBuilder sb = new StringBuilder(url);
		
		// this is in case the appendGetParams already added parameters
		if (url.indexOf("?")>-1)
		{
			sb.append("&");				
		}
		else
		{
			sb.append("?");
		}
		sb.append("token");
		sb.append("=");
		sb.append(token);
		
		return sb.toString();
	}
	
	
	public static String appendGetParams(String url, HashMap<String, String> getParams) {
		if (getParams != null && getParams.size() > 0) {
			StringBuilder sb = new StringBuilder(url);
			
			// this is in case the appendTokenParam already added a ?
			if (url.indexOf("?")>-1)
			{
				sb.append("&");				
			}
			else
			{
				sb.append("?");
			}
			
			for (Iterator<String> i = getParams.keySet().iterator(); i
					.hasNext();) {
				String key = i.next();

				try
				{
					String encodedString = URLEncoder.encode(getParams.get(key), "US-ASCII");
					
					sb.append(key);
					sb.append("=");
					sb.append(encodedString);
					
					if (i.hasNext()) {
						sb.append("&");
					}
				}
				catch (Exception e) 
				{
					e.printStackTrace();
				}
			}
			url = sb.toString();
		}

		return url;
	}

	public static String postToUrl(String url)
			throws Exception {
		InputStream is = null;
		try {
			HttpPost httpPost = new HttpPost(url);

			HttpResponse httpResponse = httpClient.execute(httpPost);
			HttpEntity httpEntity = httpResponse.getEntity();
			is = httpEntity.getContent();
			InputStreamReader isr = new InputStreamReader(is);

			BufferedReader reader = new BufferedReader(isr);
			StringBuilder sb = new StringBuilder();
			String line = null;
			while ((line = reader.readLine()) != null) {
				sb.append(line + "\n");
			}

			return sb.toString().trim();
		} finally {
			try {
				is.close();
			} catch (Exception e) {
			}
		}
	}	
	
	
	public static String postJsonDataToUrl(String url, String json)
			throws Exception {
		InputStream is = null;
		try {
			HttpPost httpPost = new HttpPost(url);
			
			if (json!=null)
			{
				httpPost.setEntity(new StringEntity(json));
				httpPost.setHeader("Accept", "application/json");
				httpPost.setHeader("Content-type", "application/json");
			}

			HttpResponse httpResponse = httpClient.execute(httpPost);
			HttpEntity httpEntity = httpResponse.getEntity();
			is = httpEntity.getContent();
			InputStreamReader isr = new InputStreamReader(is);

			BufferedReader reader = new BufferedReader(isr);
			StringBuilder sb = new StringBuilder();
			String line = null;
			while ((line = reader.readLine()) != null) {
				sb.append(line + "\n");
			}

			return sb.toString().trim();
		} finally {
			try {
				is.close();
			} catch (Exception e) {
			}
		}
	}

	public static String readUrlContentAsString(String url) throws Exception {
		InputStream is = null;
		try {
			// Making HTTP request
			HttpGet httpGet = new HttpGet(url);

			HttpResponse httpResponse = httpClient.execute(httpGet);
			HttpEntity httpEntity = httpResponse.getEntity();
			is = httpEntity.getContent();
			InputStreamReader isr = new InputStreamReader(is);

			BufferedReader reader = new BufferedReader(isr);
			StringBuilder sb = new StringBuilder();
			String line = null;
			while ((line = reader.readLine()) != null) {
				sb.append(line + "\n");
			}

			return sb.toString().trim();
		} finally {
			try {
				is.close();
			} catch (Exception e) {
			}
		}
	}

}

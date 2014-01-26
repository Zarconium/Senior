package admu.cs119.login.model;

import java.io.Serializable;

public class ServerReply implements Serializable{

	private String message;
	private int status;
	private String jsonData;
	
	public String getMessage() {
		return message;
	}
	public void setMessage(String message) {
		this.message = message;
	}
	public int getStatus() {
		return status;
	}
	public void setStatus(int status) {
		this.status = status;
	}
	public String getJsonData() {
		return jsonData;
	}
	public void setJsonData(String jsonData) {
		this.jsonData = jsonData;
	}
	@Override
	public String toString() {
		return "ServerReply [message=" + message + ", status=" + status
				+ ", jsonData=" + jsonData + "]";
	}
	
	
	

}

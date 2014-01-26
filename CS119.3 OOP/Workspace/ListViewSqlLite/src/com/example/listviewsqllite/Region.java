package com.example.listviewsqllite;

public class Region {

private String name = null;
private String region = null;
public String getName() {
	return name;
}
public void setName(String name) {
	this.name = name;
}
public String getRegion() {
	return region;
}
public void setRegion(String region) {
	this.region = region;
}
@Override
public String toString() {
	return "Region [name=" + name + ", region=" + region + "]";
}



}
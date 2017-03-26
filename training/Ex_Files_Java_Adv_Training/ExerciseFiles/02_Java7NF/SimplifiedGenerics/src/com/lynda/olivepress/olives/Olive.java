package com.lynda.olivepress.olives;

import java.util.ArrayList;

public class Olive {
	public static ArrayList<Olive> jar;
	static 
	{
		jar = new ArrayList<>();
		jar.add(new Olive("Kalamata", 0x000000));

		jar.add(new Olive("Kalamata", 0x000000));

		jar.add(new Olive("Kalamata", 0x000000));

		jar.add(new Olive("Kalamata", 0x000000));
	}
	public String oliveName = "Kalamata";
	public long color = 0x000000;
	
	public Olive() {
	}

	public Olive(String oliveName) {
		this.oliveName = oliveName;
	}
	
	public Olive(String oliveName, long color) {
		this(oliveName);
		this.color = color;
	}
	
	public String toString() {
		return "name: " + this.oliveName + ": " + "color: " +  this.color;
	}

	
	public enum type
	{
		NAME,TYPE, PLACE;
	}
}

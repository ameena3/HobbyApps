package com.lynda.javatraining;

import java.lang.reflect.Constructor;
import java.text.NumberFormat;
import java.util.ArrayList;
import java.util.List;
import java.util.Random;

import com.lynda.olivepress.olives.Olive;

public class Main {

	public static void main(String[] args) throws Exception {

		Olive o1 = new Olive("Kalamata", 0x000000);
		Olive o2 = new Olive("Picholine", 0x00FF00);
		Olive o3 = new Olive("Ligurio", 0x000000);
		
		//Olive[] olives = {o1, o2, o3};
		List<Olive>  olivelist = new ArrayList<>();
		olivelist.add(o1);
		olivelist.add(o2);
		olivelist.add(o3);
		System.out.println(olivelist);
	//	System.out.println(o2);
		int no = 100_000_000;
		NumberFormat no1 = NumberFormat.getInstance();
		System.out.println(no1.format(no));
		String name = "meena";
		
		Random  r = new Random();
		Olive o = olivelist.get(r.nextInt(4));
		
		switch(o.oliveName)
		{
		case "Kalamata":
			System.out.println("The name is Kalamata");
			break;
		case "Picholine":
			System.out.println("the name is Picholine");
			break;
		case "Ligurio":
			System.out.println("the name is Ligurio");
			break;
			default:
				System.out.println("Nothing");
				break;
		}
		
		ArrayList<Olive> oar = Olive.jar;
		for(Olive oh : oar)
		{
			System.out.println(oh);
		}
		
		Class<?> c = o1.getClass();
		Constructor<?>[] constructors = c.getConstructors();
		System.out.println("the no of constructors are: " + constructors.length);
	}
	
}

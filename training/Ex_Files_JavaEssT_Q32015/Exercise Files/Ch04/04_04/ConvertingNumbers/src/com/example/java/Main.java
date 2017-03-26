package  com.example.java;

import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;

public class Main
{
	public static void main(String[] argc)
	{
		List<Integer> array = new ArrayList<>();
		
		System.out.println("Enter the number of elements that you want sorted");
		int no ;
		Scanner value = new Scanner(System.in);
		no = value.nextInt();
			
		for(int a =0 ; a< no;a++)
		{
			array.add(value.nextInt()); 
		}
		array.sort(null);
		
		System.out.println("Enter the value to be searched");
		
		no = value.nextInt();
		
		if(binarysearch(array, no))
		{
			System.out.println("the value is present");
		}
		if(sbinarysearch(array,0, (array.size()), no))
		{
			System.out.println("the value is present");
		}
		
		value.close();
	}
	
	
	static boolean binarysearch(List<Integer> array, int no)
	{
		int low,mid ,high;
		
		low = 0;
		high = array.size();
		mid = (low + high) / 2;
		
		while(low <= high)
		{
			if(array.get(mid) == no)
				return true;
			else
			{
				if(array.get(mid) < no)
				{
					low = mid + 1;
					mid = (low + high) / 2;
				}
				else if (array.get(mid) > no)
				{
					high = mid - 1; 
					mid = (low + high) / 2;
				}
			}

		}
		
		return false;
	}
	static boolean sbinarysearch(List<Integer> array,int low, int high, int no)
	{
		int mid;
		
		mid = (low + high) / 2;
		
		if(low <= high)
		{
			if(array.get(mid) == no)
				return true;
			else
			{
				if(array.get(mid) < no)
				{
					low = mid + 1;
					sbinarysearch(array, low, high, no);
				}
				else if (array.get(mid) > no)
				{
					high = mid - 1; 
					sbinarysearch(array, low, high, no);
				}
			}

		}
		
		return false;
	}
}
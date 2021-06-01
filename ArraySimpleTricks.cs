using System;
class ArraySimpleTricks{
	public static void Main(String[] ar){
		int[] a={1,5,7,2,4,9,3};
		int[] b=new int[7];
		// sorting an array
		Console.WriteLine("before sorting of array a");
		display(a);

		Console.WriteLine("after sorting of array a");
		Array.Sort(a);
		display(a);
		// reversing an array
		Console.WriteLine("after Reversing of array a");
		Array.Reverse(a);
		display(a);
		// finding length of an array
		Console.WriteLine("Length of array a");
		Console.WriteLine(a.Length);
		// searching an element from the array

		Console.WriteLine("Enter element to search from array a");
		int search=Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("{0} found at {1}" ,search,Array.IndexOf(a,search));
        
        // copying an array to another array
        Console.WriteLine("----Afer copying array a to b,The array b will be like -------");
        Array.Copy(a,b,7);
        display(b);
        // clearing datas from the array
		Console.WriteLine("After clearing");
		Array.Clear(a,0,a.Length);
		display(a);
	}

		public  void display(Array ar)
		{
			foreach(int i in ar){
			Console.WriteLine(i);
		}
	}

		
	}

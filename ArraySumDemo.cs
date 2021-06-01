using System;
public class ArraySumDemo{
	public static void Main(String[] ar){
		int i,s=0;
		int[] a=new int[4];
		Console.WriteLine("Enter elements");
		for(i=0;i<4;++i){
			a[i]=Convert.ToInt32(Console.ReadLine());
		}
		for(i=0;i<4;++i){
			s=s+a[i];
		}
		foreach(int arr in a){
			Console.WriteLine(arr);
		}
		Console.WriteLine("sum is {0}",s);

	}
}
using System;
class foreacharraydemo{
	public static void Main(String[] ar){
		// int[] a= new int[10];
		int n=5,i;
		int[] a=new int[n];
		
		// n=Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Enter array elements");
		for(i=0;i<n;++i){
			a[i]=Convert.ToInt32(Console.ReadLine());
		}
		// int[] a={1,2,3,4,5,6};
		foreach(int j in a){
			Console.WriteLine(j);
		}
	}
}
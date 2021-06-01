using System;

class Merge{
	public static void Main(String [] ar){
	int[]a= new int[90];
	int[]b= new int[90];
int n,i,m;
	Console.WriteLine("entyer n");
	n=Convert.ToInt32(Console.ReadLine());
   	for(i=0;i<n;++i){
		a[i]=Convert.ToInt32(Console.ReadLine());
	}
	Console.WriteLine("--------- first array----------");
	for(i=0;i<n;++i){
		Console.WriteLine(a[i]);
	}
		Console.WriteLine("------second array elements -----");
	Console.WriteLine("entyer n");
	m=Convert.ToInt32(Console.ReadLine());
   	for(i=0;i<m;++i){
		b[i]=Convert.ToInt32(Console.ReadLine());
	}
	Console.WriteLine(" ------second array--------");
	for(i=0;i<m;++i){
		Console.WriteLine(b[i]);
	}

	Console.WriteLine("--------Merfge 2 arrayas-----");

	}
}
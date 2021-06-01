using System;

class ArraySum{
	public static void Main(String [] ar){

	int[]a=new int[90];
	int n,i,av;
	int s=0;

	Console.WriteLine("Enter Values ");
	n=Convert.ToInt32(Console.ReadLine());

	for(i=0;i<n;++i){
		a[i]=Convert.ToInt32(Console.ReadLine());
		s=s+a[i];
			}
av=s/n;
	Console.WriteLine("Sum = {0} and average is {1}",s,av);

	}
}
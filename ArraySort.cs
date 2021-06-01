using System;

class ArraySort{
	public static void Main(String [] ar){
		int i,j,temp,n;
		int[] a= new int[90];
		Console.WriteLine("How many values to be entered ");
		n=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("--Enter array elements--");
		for(i=0;i<n;++i){
			a[i] = Convert.ToInt32(Console.ReadLine());
		}
		for(i=0;i<n;++i){
			for(j=i+1;j<n;++j){
				if(a[i] > a[j]){
					temp=a[i];
					a[i]=a[j];
					a[j]=temp;
				}
			}
		}
		Console.WriteLine("----- sorted array-----");
		for(i=0;i<n;++i){
			Console.WriteLine(a[i]);
		}

	}
}
	
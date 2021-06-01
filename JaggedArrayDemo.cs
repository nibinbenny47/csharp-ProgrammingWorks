using System;
public class jaggedArrayDemo{
	public static void Main(String[] ar){
		long[][] jar=new long[3][];
		jar[0]= new long[]{1,2,3};
		jar[1]=new long[]{3,4};
		jar[2]=new long[]{5,6,7};
		Console.WriteLine("values in a jagged array");
		for(int i=0;i<jar.GetLength(0);++i){
			long[] innerarray=jar[i];
			Console.WriteLine();
			for(int j=0;j<innerarray.Length;j++)
			Console.Write(innerarray[j]+"\t");

		}
	}
}
using System;
class JaggedArray
	{
	  static void Main()
	     {
		long[][]jar=new long[3][];
		jar[0]=new long[]{1,2,3};
		jar[1]=new long[]{4,5};
		jar[2]=new long[]{6,7,8,9};
		Console.WriteLine("The value in the jagged arryare:");
		for(int i=0; i<jar.GetLength(0);i++)
		   {
			long[] inner_aray=jar[i];
			Console.WriteLine();
			for(int j=0;j<inner_aray.Length;j++)
			   Console.Write(inner_aray[j]+"\t");
		   }
		}
	}

using System;
class foreachdemo{
	public static void Main(String[] ar){
		foreach(String str in ar){
			Console.WriteLine(str + "\t");
			foreach (char c in str){
			Console.WriteLine(c +"\t");
		}
		}
	}
}
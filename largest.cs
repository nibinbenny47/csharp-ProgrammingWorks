using System;
class largest{
	public static void Main(String [] ar) {
		int a,b,c;
		Console.WriteLine("Enter 3 nos");
		a=Convert.ToInt32(Console.ReadLine());
		b=Convert.ToInt32(Console.ReadLine());
		c=Convert.ToInt32(Console.ReadLine());
		if(a > b){
			if(a > c){
				Console.WriteLine("a is large");
			}
			else{
				Console.WriteLine("c is large");
			}
		}
		else{
			Console.WriteLine("b is large");
		}
	}
}
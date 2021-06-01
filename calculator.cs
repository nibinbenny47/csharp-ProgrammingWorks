using System;
class calculator{
	public static void Main(String[] ar){
	int a,b,c;
	String x,y;
	Console.WriteLine("enter 2 num");
	x=Console.ReadLine();
	y=Console.ReadLine();
	a=Convert.ToInt32(x);
	b=Convert.ToInt32(y);
	c=a+b;
	Console.WriteLine("Sum of {0} and {1} ={2}",a,b,c);
	}
}
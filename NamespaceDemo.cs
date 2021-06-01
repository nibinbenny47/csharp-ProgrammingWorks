using System;
namespace NamespaceDemo{
	public class Demo{
		int a,b,c;
		public void enter(){
			Console.WriteLine("enter 2 numbers");
			a=Convert.ToInt32(Console.ReadLine());
			b=Convert.ToInt32(Console.ReadLine());
			c=a+b;
			Console.WriteLine("sum is {0}",c);
		}
	}
}
using System;
class first{
	int a,b;
	public void enter(){
		Console.WriteLine("Enter 2 numbers");
		a=Convert.ToInt32(Console.ReadLine());
		b=Convert.ToInt32(Console.ReadLine());

	}
	class second :first{
		int c;
		public void sum(){
			c=a+b;
			Console.WriteLine("sum is {0}",c);
		}
	}
	class SingleInheritance{
		public static void Main(String [] ar){
			second obj=new second();
			obj.enter();
			obj.sum();
		}
	}
}
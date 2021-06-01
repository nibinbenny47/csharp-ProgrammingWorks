using System;
abstract class first{
	public abstract  void enter();
	public void show(){
		Console.WriteLine("heelo world");
	}

}
class second:first{
	public int a,b,c;
	public override void enter(){
		Console.WriteLine("enter a and b");
		a=Convert.ToInt32(Console.ReadLine());
		b=Convert.ToInt32(Console.ReadLine());


	}
	public void calculate(){
		c=a+b;
		Console.WriteLine(c);
	}
}
class AbstractClass{
	public static void Main(String[] ar){
		second obj=new second();
		obj.enter();
		obj.calculate();
		obj.show();
	}

}
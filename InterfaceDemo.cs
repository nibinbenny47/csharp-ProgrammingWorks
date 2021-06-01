using System;
interface  first{
	 void enter();
	void show();
}
class second:first{
	public int a,b;
	public void enter(){
		Console.WriteLine("enter 2 no:");
		a=Convert.ToInt32(Console.ReadLine());
		b=Convert.ToInt32(Console.ReadLine());

	}
	public void show(){
		Console.WriteLine(a);
		Console.WriteLine(b);
	}
}
class InterfaceDemo{
	public static void Main(String[] ar){
		second obj=new second();
		obj.enter();
		obj.show();
	}

}
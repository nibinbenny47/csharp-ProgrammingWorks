using System;
class first{
	public first(){
		Console.WriteLine("base class");
	}
	~first(){
		Console.WriteLine("base class destr");
	}
}
class second:first{
	public second(){
		Console.WriteLine("derei class");
	}
	~second(){
		Console.WriteLine("derf class dest");
	}
}
class ConstructorInheritance{
	public static void Main(String[] ar){
		second obj=new second();
	}
}
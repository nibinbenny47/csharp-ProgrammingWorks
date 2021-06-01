using System;
class first{
	public void show(){
		Console.WriteLine("heelo world");
	}
}
class second:first{
	new public void show(){
Console.WriteLine("heelo welcome");
	}
}
class MethodOverriding{
public static void Main(String[] ar){
	second obj=new second();
	obj.show();
}
}
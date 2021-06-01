using System;
public class drawobj{
	public virtual  void draw(){
		Console.WriteLine("this os virtual draw method");
	}
}
public class line:drawobj{
	public override void draw(){
		Console.WriteLine("this is sthe draw method of line");
	}
}
public class circle:drawobj{
	public override void draw(){
	     Console.WriteLine("this is sthe draw method of circle");

	}
}
public class square:drawobj{
	public override void draw(){
	     Console.WriteLine("this is sthe draw method of square");

	}
}
public class MethodOverridingDemo1{
	public static void Main(String[] ar){
		drawobj[] obj=new drawobj[4];
		obj[0]=new drawobj();
		obj[1]=new line();
		obj[2]=new circle();
		obj[3]=new square();
		foreach(drawobj it in obj){
			it.draw();
		}


	}
}
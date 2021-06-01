using System;
class calculate{
	int a,b;
	public calculate(int x,int y){
		a=x;
		b=y;
	}
	public static calculate operator +(calculate objcal){
		objcal.a= 2 + objcal.a;
		objcal.b= 2 + objcal.b;
		return objcal;

	}
	public void show(){
		Console.WriteLine("a is {0}",a);
		Console.WriteLine("b is {0}",b);
	}
}
class OperatorOverloading{
	public static void Main(String [] ar){
		calculate objcal=new calculate(9,5);
		objcal.show();
		objcal= + objcal;
		objcal.show();
	}
}
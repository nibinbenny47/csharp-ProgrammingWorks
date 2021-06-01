using System;
class calculate
{
	int a,b,c;
	public calculate(){
		 a=10;
		b=5;
	}
	public calculate(int x,int y){
		a=x;
		b=y;

	}
	public void sum(){
		c=a+b;
	}
}
class ConstructorDemo{
	public static void Main(String[] ar){
		calculate obj=new calculate();
		calculate obj1=new calculate(3,4);
		obj.sum();
		obj1.sum();
	}
}
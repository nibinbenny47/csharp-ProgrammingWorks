using System;
class calculate{
	int a,b,c,s;
	public calculate(){
		Console.WriteLine("EWnter 2 num");
		a=Convert.ToInt32(Console.ReadLine());
		b=Convert.ToInt32(Console.ReadLine());
		c=a+b;
		Console.WriteLine("sum is {0}",c);
	}
	public calculate(int x,int y){
		s=x+y;
		Console.WriteLine("sum is {0}",s);
	}
}
class ConstructorOverloading{
	public static void Main(String[] ar){
		calculate obj=new calculate();
		calculate obj2=new calculate(5,8);

	}
}
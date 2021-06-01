using System;
class calculate{
	int a,b,c;
	double f;
	public void add(){
		Console.WriteLine("EWnter 2 num");
		a=Convert.ToInt32(Console.ReadLine());
		b=Convert.ToInt32(Console.ReadLine());
		c=a+b;
		Console.WriteLine("sum is {0}",c);

	}
	public void add(int x,int y){
		
		c=x+y;
		Console.WriteLine("sum is {0}",c);

	}
	public double  add(double x,double y){
		f=x+y;
		return f;
	}
}
class FunctionOverloadingDemo{
	public static void Main(String[] ar){
		double result;
		calculate obj=new calculate();
		obj.add();
		obj.add(6,7);
		Console.WriteLine("enter 2 floatvalues");
		double num1=Convert.ToDouble(Console.ReadLine());
		double num2=Convert.ToDouble(Console.ReadLine());
		result=obj.add(num1,num2);
		
		Console.WriteLine("sum is {0}",result);
			}
}
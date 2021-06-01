using System;
using NamespaceDemo;
class result{
	int a,b,c;
	public void inputdata(){
		Console.WriteLine("enter 2 numbers");
		a=Convert.ToInt32(Console.ReadLine());
		b=Convert.ToInt32(Console.ReadLine());
		

	}
	public void calculate(){
		try{
			c=a/b;
			Console.WriteLine("result is {0}",c);
		}
		catch(Exception ex){
			Console.WriteLine("errror is  {0}",ex.Message);
		}
		finally
      {
            Console.WriteLine("thank you"); 
      }
 

		
	}
}
class ExceptionDemo{
	public static void Main(String[] ar){
		Demo obj1=new Demo();

		result obj=new result();
		obj1.enter();
		obj.inputdata();
		obj.calculate();
	}
}
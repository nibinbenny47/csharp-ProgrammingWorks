using System;

class calculator{
	int a,b,c;
	/*public void enter(){
		Console.WriteLine("entr 2 nm");
		a=Convert.ToInt32(Console.ReadLine());
			b=Convert.ToInt32(Console.ReadLine());
	}*/
	public void cal(int a,int b){
		this.a=a;
		this.b=b;
		c=a+b;
	}
	public void display(){
		Console.WriteLine("sum is {0}",c);
	}
}
class func{
	public static void Main(String [] ar){
		calculator obj=new calculator();
		//obj.enter();
		obj.cal(8,9);
		obj.display();

	}
}
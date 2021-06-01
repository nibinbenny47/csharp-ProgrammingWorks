using System;
interface first{
	void enter();
	void add();
	void show();
}
interface second{
	void diff();
	void show();
}
class result:first,second{
	public int a,b,s,d;
	public void enter(){
		Console.WriteLine("entr a and b");
		a=Convert.ToInt32(Console.ReadLine());
		b=Convert.ToInt32(Console.ReadLine());
	}
	public void add(){
		s=a+b;
	}
	public void diff(){
		d=a-b;
	}
	 public void show(){
		Console.WriteLine("sum is {0}",s);
	}
	void second.show(){
	Console.WriteLine("diff is {0}",d);

	}
}
class ExplicitInterfaceDemo{
	public static void Main(String[] ar){
		result obj=new result();
		obj.enter();
		obj.add();
		obj.diff();
		
		first f=obj;
		second s=obj;
		f.show();
		s.show();
	}
}
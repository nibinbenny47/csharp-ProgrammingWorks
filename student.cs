using System;

class marklist{
	int a,m1,m2,m3,total;
	string grade,b;
	public void enter(){
		Console.WriteLine("entr roll no");
		a=Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("entr name");
		b=Console.ReadLine();
		Console.WriteLine("marks of 3 subjects");
		m1=Convert.ToInt32(Console.ReadLine());
		m2=Convert.ToInt32(Console.ReadLine());
		m3=Convert.ToInt32(Console.ReadLine());
	}
	public void cal(){
		total=m1+m2+m3;
		if(total>100){
			grade="A";
		}
		else{
			grade="B";
		}

	}
	public void display(){
		Console.WriteLine("Name is {0}",b);
		Console.WriteLine("total is {0}",total);
		
		Console.WriteLine("grade is {0}",grade);;
	}
}
class student{
	public static void Main(String [] ar){
		int n,i;
		Console.WriteLine("enter n");
		n=Convert.ToInt32(Console.ReadLine());
		marklist obj=new marklist();
		for(i=0;i<n;++i){
		obj.enter();
		obj.cal();
		

		}
		Console.WriteLine("------Display student details-----");
		for(i=1;i<=n;++i){
			Console.Write(i +" ");
			obj.display();
		}
		
	
	}
}
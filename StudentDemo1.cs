using System;
namespace StudentDemo1{
	public class details{
		int roll,mark;
		string name;
		public void enter(){
			Console.WriteLine("enter roll no");
			 roll=Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("enter name");
			 name=Console.ReadLine();
			Console.WriteLine("enter marks ");
			 mark=Convert.ToInt32(Console.ReadLine());
		}
		public void show(){
			Console.WriteLine("name is {0}",name);
			Console.WriteLine("rollno is {0}",roll);
			Console.WriteLine("maks is {0}",mark);
		}
	}
}
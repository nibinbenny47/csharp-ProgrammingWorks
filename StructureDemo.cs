using System;
 
struct student{
	public int roll;
	public string name;

}
class StructureDemo{

	public static void Main(String[] ar){
		student obj=new student();
		Console.WriteLine("Enter name");
		obj.name=Console.ReadLine();
		Console.WriteLine("enter rolll");
		obj.roll=Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("name is {0} and roll no is {1}",obj.name,obj.roll);

	}
}

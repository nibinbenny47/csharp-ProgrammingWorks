using System;
class calculate
 {
      public void add(ref int a,ref int b)
       {
	int c;
	c=a+b;
	Console.WriteLine("sum {0}",c);
       }
}
 
class ReferenceDemo
{
 public static void Main(String[] ar)
  {
      calculate cal=new calculate();
      int x=10,y=20;
     cal.add(ref x,ref y);
 }
}

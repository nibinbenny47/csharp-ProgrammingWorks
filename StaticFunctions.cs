 using System;
 class calculate
 {
     public static int s;
     public void count()
       {
	s++;
       }
    public static int show()
     {
        return s;
     } 
}
 
 
class StaticFunctions

{
 public static void Main()
  {
       int c;
      calculate cal=new calculate();
      cal.count();
      cal.count();
      c=calculate.show(); 
      Console.WriteLine("count = {0}",c);
 }
}

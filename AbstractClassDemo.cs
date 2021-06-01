using System;
abstract class first
{
         public abstract void enter();
        
          public void show()
             {
   	      Console.WriteLine("welcome");
 	 }
}
class derived:first
{
  public int a,b,c,d;
  
   public override void enter()
    {
       Console.WriteLine("enter number-1 ");
       a=Convert.ToInt32(Console.ReadLine());
       Console.WriteLine("enter number-2 ");
       b=Convert.ToInt32(Console.ReadLine());
    }
   public void cal()
   {
      c=a+b;
      d=a-b;
      Console.WriteLine("Sum = {0}",c);
      Console.WriteLine("Diff = {0}",d);
   }
}
 
class AbstractClassDemo
{
 public static void Main()
  {
  
    derived obj=new derived();
    obj.enter();
    obj.cal();
 
  }
}

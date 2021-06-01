using System;
class testdelegate{
  public delegate void  delegexample(int a,int b);

class calculation{
  int r;
  public void  add(int a,int b){
    r=a+b;
    Console.WriteLine(r);
  }
  public void  sub(int a,int b){
    r=a-b;
    Console.WriteLine(r);
  }
}
class Deligate{
  public static void Main(String[] ar){
    calculation obj=new calculation();
    delegexample obj1=new delegexample(obj.add);
    delegexample obj2=new delegexample(obj.sub);
    obj1(10,20);
obj2(20,5);
    // Console.WriteLine("sum is {0}",t);
    //     Console.WriteLine("sub is {0}",s);

  }
}
}
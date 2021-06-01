using System;
class Perfect{
int n,a,b;
	public static void Main(String [] ar){
		Console.WriteLine("enter 2 no");
		a=Convert.ToInt32(Console.ReadLine());
		b=Convert.ToInt32(Console.ReadLine());
		 for(n=a;n<=b;++n)
    {
    i=1;
    sum = 0;
    while(i<n)
	{
      if(n%i==0)
           sum=sum+i;
          i++;
    }
    if(sum==n)
      Console.WriteLine("{0} ",n);
    
      Console.WriteLine("\n");
 }  

	}
}
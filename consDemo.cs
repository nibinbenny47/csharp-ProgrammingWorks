using System;

class StrongConstruct
{
	// double d = 145.0; 
	public int n;
     public  int temp;
         int s1=0;
         int j,fact,i;
         
  
  public StrongConstruct()
  {
  	Console.WriteLine("enter number");
  	n=Convert.ToInt32(Console.ReadLine());
  	temp=n;


  }
  public int  intstrong(){
  	for(j=n;j>0;j=j/10) 
    {  
  
        fact = 1;  
        for(i=1; i<=j % 10; i++)  
        {  
            fact = fact * i;  
        }  
         s1 = s1 + fact;  
 
    }  
  
    if(s1==temp)  
    {  
    	
    	 return 1;
       // Console.Write("\n{0} is Strong number.\n\n", temp);  
    }  
    else  
    {  
    	return 0;
        // Console.Write("\n{0} is not Strong number.\n\n", temp);  
    }  
  }
}
class consDemo
{
  public static void Main(string[] args)
  {
    StrongConstruct obj = new StrongConstruct();
    //StrongConstruct obj1=new StrongConstruct(); 
    // Console.WriteLine(obj.n);
   Console.WriteLine(obj.intstrong()) ; 
  
}
}

using System;
class StrongConstruct
{
	// double d = 145.0; 
	// public double num;
         int n,temp;
         int s1=0;
         int j,fact,i;
         int ret1=1;
         int ret2=0;

         
  
  public StrongConstruct()
  {
  	Console.WriteLine("enter number");
  	
  	 n = Convert.ToInt32(Console.ReadLine());
  	     temp = n;  

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
      return ret1;
        // return(Console.Write("\n{0} is Strong number.\n\n", temp));  
    }  
    else  
    {  
      return ret2;
        // Console.Write("\n{0} is not Strong number.\n\n", temp);  
    }  
  }
  static void Main(string[] args)
  {
    StrongConstruct obj = new StrongConstruct();
    
    Console.WriteLine(obj.intstrong()); 
    // if(obj.intstrong == 1) {
    //   Console.Write("\n{0} is Strong number.\n\n", temp);
    // }
    // else{
    //   Console.Write("\n{0} is not Strong number.\n\n", temp);
    // }
}
}

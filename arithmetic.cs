using System;
class arithmetic{
	public static void Main(String [] ar){
	int a,b,c;
	  string ch;
	Console.WriteLine("enter 2 num");
	a=Convert.ToInt32(Console.ReadLine());
	b=Convert.ToInt32(Console.ReadLine());
	Console.WriteLine("enter choice");
	ch=Console.ReadLine();
	Console.WriteLine("1:sum\n2:diff");
	switch (ch){
	case "+": c=a+b;
	Console.WriteLine(c);
	break;

	
	case "-": c=a-b;
	Console.WriteLine(c);
	break;	
	
	default:
	Console.WriteLine("INCVALID");
break;
       
}

	
	

	}
}
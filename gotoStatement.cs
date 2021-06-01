using System;
class gotoStatement{
	public static void Main(String [] ar){
		int n;
		
		
		Console.WriteLine("enter number");
		n=Convert.ToInt32(Console.ReadLine());
		if(n<18){
			goto label1;
		}
		else{
			goto label2;
		}
		label1:
		Console.WriteLine("you are not eligible to vote");
		label2:
		Console.WriteLine("you are eligible to vote");
	}
}

using System;
class Loop{
	public static void Main(String [] ar){
	int num,temp;
int rev=0;
int sum=0;
int dig;
	Console.WriteLine("entr num");
	num=Convert.ToInt32(Console.ReadLine());
	temp=num;
	while(num != 0){
		dig=num % 10;
		sum=sum+dig;
		rev=rev *10 + dig;
		num=num/10;
	}
	if(temp == rev){
		Console.WriteLine("palindrome");
	}
	else{
		Console.WriteLine("no palindrome");

	}
	Console.WriteLine("rev is{0}",rev);
Console.WriteLine("sum is{0}",sum);
	}
}
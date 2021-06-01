using System;
class first{
	public int n;
	public int temp,dig;
	public int rev=0;
	public void input(){
		Console.WriteLine("ENter number");
		n=Convert.ToInt32(Console.ReadLine());
		temp=n;

	}
}
	class second :first{
		public void amstrong(){
		while(n!=0){
			dig=n%10;
			rev=rev+dig*dig*dig;
			n=n/10;
		}
	}
}
	class third:second{
		public void show(){
		if(temp == rev){
			Console.WriteLine("{0} is an amstromng number",temp);
		}
		else{
			Console.WriteLine("{0} is not an amstromng number",temp);
		}
	}
	}
class MultilevelInheritance{
	public static void Main(String [] ar){
		third obj=new third();
		obj.input();
		obj.amstrong();
		obj.show();
	}
}
	

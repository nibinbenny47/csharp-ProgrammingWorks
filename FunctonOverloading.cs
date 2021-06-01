using System;
class first{
	public int num1,num2,num3;
/*	public string temp1,temp2,temp3;
*/	// public int a,b,c;
	public first(){
		Console.WriteLine("Enter 3 numbers");
		num1=Convert.ToInt32(Console.ReadLine());
		num2=Convert.ToInt32(Console.ReadLine());
        num3=Convert.ToInt32(Console.ReadLine());

	}
	public void largest(){
		if(num1 > num2){
			if(num1 > num3){
				Console.WriteLine("{0} is large",num1);
			}
			else{
			Console.WriteLine("{0} is large",num3);
			}
		}
		else{
		Console.WriteLine("{0} is large",num2);
		}
	}
	public int largest(int a,int b ,int c){
		// this.a=a;
		// this.b=b;
		// this.c=c;
		if(a > b){
			if(a > c){
				return a;
				
				
			}
			else{
			return c;
		
			}
		}
		else{
			return b;
	       

		}

	}
}
class FunctonOverloading{
	public static void Main(String [] ar){
		first obj=new first();
		int t;
		// obj.enter();
		obj.largest();
		t=obj.largest(3,4,5);
		Console.WriteLine("{0} is large",t);
	}
} 
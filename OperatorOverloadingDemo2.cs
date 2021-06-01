using System;
class calculate{
	int num;
	public calculate(){
		num=0;
	}
	public calculate(int a){
		num=a;
	}
	public  static calculate operator +(calculate objcal1 ,calculate objcal2){
		calculate objcal3=new calculate();
		objcal3.num=objcal1.num + objcal2.num;
		return objcal3;
	}
	public void show(){
		Console.WriteLine("value is {0}",num);
	}
}
class OperatorOverloadingDemo2{
	public static void Main(String[] ar){
		calculate objcal1=new calculate(7);
		calculate objcal2=new calculate(8);
		calculate objcal3=new calculate();
		objcal3=objcal1+objcal2;
		objcal1.show();
		objcal2.show();
		objcal3.show();

	}
}
using System;
using System.Threading;
class MulitithreadDemo3{
	public static void childthread1(){
		Console.WriteLine("child thread 1 starts");
		for(int i=1;i<=5;++i){
			Console.WriteLine("{0}",i);
		}
		Console.WriteLine("child thread 1 finished");
	}
	public static void childthread2(){
		Console.WriteLine("child thread 2 starts");
		for(int i=5;i>=1;i--){
			Console.WriteLine("{0}",i);
		}
		Console.WriteLine("child thread 2finished");
	}
	public static void Main(){

		ThreadStart cth1 = new ThreadStart(childthread1);
		ThreadStart cth2 = new ThreadStart(childthread2);

		Thread th1=new Thread(cth1);
		Thread th2=new Thread(cth2);
		th1.Start();
		th2.Start();
	}
}
using System;
using System.Threading;
class MultithreadDemo4{
	public static void childThread(){
		Console.WriteLine("child thread starts");
		Console.WriteLine("sleep  for some seconds");
		Thread.Sleep(1000);
		Console.WriteLine("wake up");

	}
	public static void Main(){
		ThreadStart cth=new ThreadStart(childThread);
		Thread th =new Thread(cth);
		th.Start();
		// th.Abort();
	}
}
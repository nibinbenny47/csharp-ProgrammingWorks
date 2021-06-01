using System;

using System.Threading;
class MultithreadDemo2{
	public static void childthread(){
		Console.WriteLine("child thread starts");
	}
	public static void Main(){
		ThreadStart cth=new ThreadStart(childthread);
		Thread th=new Thread(cth);
		th.Start();
	}
}
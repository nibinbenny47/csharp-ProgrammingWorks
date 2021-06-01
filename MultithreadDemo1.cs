using System;
using System.Threading;
class MultithreadDemo1{
	public static void Main(){
		Thread th=Thread.CurrentThread;
		th.Name="Main thread";
		Console.WriteLine("thread is {0}",th.Name);
	}
}
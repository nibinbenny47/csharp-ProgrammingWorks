using System;
using System.Diagnostics;
class CurrentProcessRunning{
	public static void Main(String[] ar){
		Console.WriteLine("Curent process is" + Process.GetCurrentProcess().ProcessName);
		Console.WriteLine("Other process runnng int the system are ");
		foreach(Process Pr in Process.GetProcesses()){
			Console.WriteLine(Pr.Id + "\t" + Pr.ProcessName);
			 Console.ReadLine();
            }
            Console.ReadLine();
       
	}
}
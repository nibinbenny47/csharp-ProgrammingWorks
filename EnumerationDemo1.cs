using System;
class EnumerationDemo1{
	
		enum car {maruti,alto,zen};
		public static void Main(String[] ar){
			int a=(int)car.alto;
			int b=(int)car.zen;
			Console.WriteLine(a);
			Console.WriteLine(b);
		}
	}

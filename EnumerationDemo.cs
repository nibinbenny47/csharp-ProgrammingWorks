using System;
class EnumerationDemo{
	enum days {sun=1,mon,tue,thu,fri,sat};
	public static void Main(String[] ar){
		int first=(int)days.sun;
		int last=(int)days.sat;
		Console.WriteLine("sunday {0}",first);
		Console.WriteLine("saturday {0}",last);

	}
}
using System;
class gotoStatement2{
	public static void Main(String[] ar){
		String ch;
		Console.WriteLine("Enter character");
		ch=Console.ReadLine();
		switch(ch){
			case "a":
			Console.WriteLine("{0} is vowel",ch);
			break;
			case "e":
			Console.WriteLine("{0} is vowel",ch);
			break;
			case "i":
			Console.WriteLine("{0} is vowel",ch);
			break;
			case "o":
			Console.WriteLine("{0} is vowel",ch);
			break;
			case "u":
			Console.WriteLine("{0} is vowel",ch);
			break;
			
			case "A":
			goto case "a";
			case "E":
			goto case "e";
			case "I":
			goto case "i";
			default:
			Console.WriteLine("{0} not a vowel",ch);
			break;



		}
	}
}
using System;
class Find{
public static void Main(String [] ar){



string[] names = { "Steve", "Bill", "Bill Gates", "Ravi", "Mohan", "Salman", "Boski" };
var stringToFind = "Bill";
var result = Array.Find(names, element => element == stringToFind);
Console.WriteLine(result);
} 

}
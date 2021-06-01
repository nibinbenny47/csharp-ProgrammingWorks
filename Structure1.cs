using System;
class Structure1
{
struct Student
{
public string name;
public string roll;
public string grade;
}
public static void Main()
{
Student[] s = new Student[3];
for (int i = 0; i < s.Length; i++)
{
Console.Write("Enter Name: ");
s[i].name = Console.ReadLine();
Console.Write("Enter Roll No.: ");
s[i].roll = Console.ReadLine();
Console.Write("Enter grade .: ");
s[i].grade = Console.ReadLine();
}
Console.Write("\n\nNAME\t\tROLL NO.\t\t GRADE\n");
for (int i = 0; i < s.Length; i++)
{
Console.WriteLine(s[i].name + "\t\t" + s[i].roll+"\t" + s[i].grade);
}
}
}
using System;
public class Textbox
 {
    private string st=" ";
     public string text         // property name text
       {
	get
	 {
	     Return st;        //read only
	}
	set
	 {
	     st=value;        //write only; value is default
	}
       }
}
class PropertiesDemo
{
 public static void Main()
  {
      Textbox txt=new Textbox();
      txt.text="helllo";          		 // call set; write only
      Console.WriteLine(txt.text); 	// call get ; readonly
 }
}

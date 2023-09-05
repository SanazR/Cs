using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      /* string txt = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
      string txt1 = "abcdefghijklmnopqrstuvwxyz";

      Console.WriteLine("The length of the txt is: " + txt.Length );
      Console.WriteLine(txt1.ToUpper());
      Console.WriteLine(txt.ToLower()); */

      // Anotherway forconcatinating strings (instead of "+") 
      string firstName = "John ";
      string lastName = "Doe";
      string name = string.Concat(firstName, lastName);
      Console.WriteLine(name);

      string name1 = $"My name is: {firstName}{lastName}";
      Console.WriteLine(name1);

      Console.WriteLine(name[1]);



      // Full name
      string name2 = "John Doe";

      // Location of the letter D
      int charPos = name2.IndexOf("D");

      // Get last name
      string lName = name2.Substring(charPos);

      // Print the result
      Console.WriteLine(lName);

      string txt2 = "We are the so-called \"Vikings\" from the north.";
      Console.WriteLine(txt2);

      string txt3= "It\'s a cat.";
      Console.WriteLine(txt3);
      
    }
  }
}
using System;

namespace HelloWorld
{
  class Program
  {
    static void Main(string[] args)
    {
      /*Console.Write("Hello World! ");
      Console.Write("May name is Sani. ");  
      Console.Write(5+8); */

      /* int myNum = 63;
      double myDoubleNum = 2.35666661D;
      float myfloatnum = 2.502F
      int numLong = 120000500L; //Long int
      char myLetter = 'D'; //The character must be surrounded by single quotes
      bool myBool = true;
      string myText = "Hello"; //String values must be surrounded by double quotes

      ---------------------------------------------------------
      The precision of float is only six or seven decimal digits, 
      while double variables have a precision of about 15 digits. 
      Therefore it is safer to use double for most calculations.
      ----------------------------------------------------------

      Console.WriteLine(myNum); */
      
      /* string fname="Sara";
      string lanme= " Johnson";
      string fullname= fname+lanme;

      Console.WriteLine(fullname); */

      float f1 = 35e3F;
      double d1 = 12E4D;

      Console.WriteLine(f1);
      Console.WriteLine(d1);

      /* int x, y, z;
      x=y=z=10;
      Console.WriteLine(x+y+z); */

      int num1 = 9;
      double myDouble = num1; // Automatic casting: int to double

      Console.WriteLine(num1);      
      Console.WriteLine(myDouble);

      double numD = 9.78;
      int num2 = (int) numD; // Manual casting: double to int

      Console.WriteLine(numD);      
      Console.WriteLine(num2);

    }
  }
}

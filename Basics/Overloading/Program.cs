using System;
using System.Globalization;

namespace MyApplication
{
  class Program
  {
    /* Regular Way:
    static int PlusMethodInt(int x, int y)
    {
      return x + y;
    }

    static double PlusMethodDouble(double x, double y)
    {
      return x + y;
    }

    static void Main(string[] args)
    {
      int myNum1 = PlusMethodInt(8, 5);
      double myNum2 = PlusMethodDouble(4.3, 6.26);
      Console.WriteLine("Int: " + myNum1);
      Console.WriteLine("Double: " + myNum2);
    } */

    // Overloading:

    static int PlusMethod(int i, int j){
        return i + j;
    }
    static double PlusMethod(double i, double j){
        return i + j;
    }

    static void Main(string[] args){
        int myNum1= PlusMethod(1, 2);
        double myNum2= PlusMethod(3.5, 4.8);
        Console.WriteLine("Int: " + myNum1);
        Console.WriteLine("Double: " + myNum2);
    }
  }
}
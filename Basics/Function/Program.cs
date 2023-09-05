using System;

namespace MyApplication
{
  class Program
  {
    static void MyMethod(string fname="Hana", int age=10)
    {
      Console.WriteLine(fname + " Johnson is " + age);
    }

    static int MySum(int x, int y){
        return x+y;
    }

    static void KeyName(string key1, string key2, string key3){
        Console.WriteLine("The newest key is " + key3);
    }

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
      //MyMethod("Sara", 22);
      //MyMethod("Daniel", 16);
      MyMethod(); //Default value

      int z = MySum(8,16);
      Console.WriteLine (MySum(5,2));
      Console.WriteLine (z);

      KeyName(key2:"abc1", key3:"def2", key1:"ghi3"); // In this wayt thorder of the arg doesn't matter
      KeyName("jkl4","mno5","pqr6");
      
      int myNum1 = PlusMethodInt(8, 5);
      double myNum2 = PlusMethodDouble(4.3, 6.26);
      Console.WriteLine("Int: " + myNum1);
      Console.WriteLine("Double: " + myNum2);
      
    }
  }
}
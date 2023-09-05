using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      int time=22;
      string result =(time<18) ? "Good day!" : "Good night!";
      Console.WriteLine(result);


      // Switch
      int day=4;
      switch (day){
        case 1:
          Console.WriteLine("Monday");
          break;
        case 2:
          Console.WriteLine("Tuesday");
          break;
        case 3:
          Console.WriteLine("Wednesday");
          break;
        case 4:
          Console.WriteLine("Thursday");
          break;
        case 5:
          Console.WriteLine("Friday");
          break;
        default:
          Console.WriteLine("Looking forward to the Weekend.");
          break;
      }
    }
  }
}
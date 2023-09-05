using System;
using System.Linq;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {

      // Replace an element in an array
      string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};
      cars[1]= "Camery";
      /* Array.Sort(cars);
      foreach (string i in cars)
      {
        Console.WriteLine(i);
      } 

      Console.WriteLine(cars[1]); */  

      // Length of an array
     Console.WriteLine(cars.Length);

      //Other trypes of creating an array
      string[] cars1 = new string[4];
      string[] cars2 = new string[4] {"Volvo", "BMW", "Ford", "Mazda"};
      string[] cars4 = new string[] {"Volvo", "BMW", "Ford", "Mazda"};

      for(int i =0; i<cars.Length;i++){
        Console.WriteLine(cars[i]);
      }

      int[] num={1,2,3,4,5,6};
      Console.WriteLine(num.Max());
      Console.WriteLine(num.Min());
      Console.WriteLine(num.Sum());
      
    }
  }
}
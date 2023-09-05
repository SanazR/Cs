using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      string[] cars={"volvo", "BMW", "Ford","Mazda"};
      foreach (string car in cars){
        Console.WriteLine(car);
      }


      /*The continue statement breaks one iteration (in the loop), 
      if a specified condition occurs, and continues with the next 
      iteration in the loop */

      /* for (int i=0; i<10; i++){
        if(i==4){
            continue;
        }

        Console.WriteLine(i);
      } */

      // continue in while loop

      int i = 0;
      while (i < 10) 
      {
         if (i == 4) 
         {
             i++;
             continue;
         }

        Console.WriteLine(i);
        i++;
      }
    }   
   }
}

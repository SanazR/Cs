using System;

namespace MyApp{
    class Program{
        enum Level{
            Low,
            Medium,
            High
        }

        enum Months {
            Jan,
            Feb,
            Mar,
            Apr,
            May=7,
            June,
            July,
            August
        }

        static void Main(string[] args){
            /*Level myVar = Level.Low;
            Console.WriteLine(myVar); */

            int myNum = (int) Months.Feb;
            Console.WriteLine(myNum);

            int myNum2 = (int) Months.June;
            Console.WriteLine(myNum2);

            Level myVar = Level.Medium;
            switch(myVar){
               case Level.Low:
                Console.WriteLine("Low Level");
                break;
               
               case Level.Medium:
                 Console.WriteLine("Medium Level");
                 break;

               case Level.High:
                 Console.WriteLine("High Level");
                 break;
            }
        }
    }
}
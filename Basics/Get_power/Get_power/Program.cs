// See https://aka.ms/new-console-template for more information
using System;

namespace myApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine( GetPow (3, 2));
            Console.ReadLine();
        }

        static int GetPow(int baseNum, int pow)
        {
            int result = 1;

            for (int i = 0; i<pow; i++)
            {
                result *= baseNum;
            }

            return result;
        }
    }
}





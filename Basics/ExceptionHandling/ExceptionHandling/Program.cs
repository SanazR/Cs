// See https://aka.ms/new-console-template for more information
using System;

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter a number: ");
                int Num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter a number: ");
                int Num2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(Num1 / Num2);
            }
            
            /*
            catch (Exception ex) {
                Console.WriteLine(ex.Message);
            }  
            */

            catch (DivideByZeroException ex) {
                Console.WriteLine(ex.Message);
            }

            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadLine();
        }
    }
}


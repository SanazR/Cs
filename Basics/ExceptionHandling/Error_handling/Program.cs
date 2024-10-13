using System;

namespace MyApp{
  
    class Program{

        static void checkAge(int age){
        if(age < 18){
            throw new ArithmeticException("Access denied - You must be at least 18 years old.");
        }

        else{
            Console.WriteLine("Access granted");
        }

    }
        static void Main(string[] args){
            try {

                checkAge(25);
                checkAge(12);

                int[] myNum = { 1, 2, 3, 4, 5} ;
                Console.WriteLine(myNum[14]);
            }

            catch (ArithmeticException e)
            {
                Console.WriteLine(e.Message);  // Handle age-related exception
            }
            
            catch(Exception e){
                Console.WriteLine(e.Message);
            }

            finally{
                Console.WriteLine("Test is done");
            } 
        }
    }
}
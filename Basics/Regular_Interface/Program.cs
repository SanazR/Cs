using System;

namespace MyApp
{
    interface IAnimal
    {
        // Interface methods do not have bodies
        void AnimalSound();
        void Eat();
    }

    class Pig : IAnimal // Pig "implements" the IAnimal interface
    {
        // The body for methods has been provided here
        public void AnimalSound()
        {
            Console.WriteLine("The pig says Oink Oink.");
        }

        public void Eat()
        {
            Console.WriteLine("The pig eats mud.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Pig myPig = new Pig();  // Create an instance of Pig
            myPig.AnimalSound();    // Output: The pig says Oink Oink.
            myPig.Eat();            // Output: The pig eats food.
        }
    }
}

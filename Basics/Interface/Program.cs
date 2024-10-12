using System;

namespace MyApp{
   interface IAnimal{

    //inteface methods doesn't have body
     void animalSound(); 
     void eat();
   }

   class Pig: IAnimal{ //pig "implements" the IAnimal interface

        //The body for mehtods have been provided here
        public void animalSound(){ 
            Console.WriteLine("The pig says Oinks Oinks.");
        }

        public void eat(){
            Console.WriteLine("The pig eats mud.");
        }
    }

    class Program{
        static void Main(string[] args) {
            Pig myPig = new Pig();
            myPig.animalSound();
            myPig.eat();
        }
    }


}
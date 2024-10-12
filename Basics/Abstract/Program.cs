using System;

namespace MyApp{
    abstract class Animal{
        public abstract void animalSound(); //anstract method doesn't have a body
        public void sleep(){  //Regular method
            Console.WriteLine("Zzz");
        } 

    }

    class Pig: Animal{
        public override void animalSound(){ //The body for animalSound() has been provided here
            Console.WriteLine("The pig says Oinks Oinks.");
        }
    }

    class Program{
        static void Main(string[] args){
            Pig myPig = new Pig();
          
            myPig.animalSound();
            myPig.sleep();
        }
    }

}
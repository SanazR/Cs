using System;

namespace MyApp{

    class Animal{
        public virtual void animalSound(){
            Console.WriteLine("The animal makes a sound.");
        }
    }

    class Pig: Animal{
        public override void animalSound(){
            Console.WriteLine("The pig says Oinks Oinks.");
        }
    }

    class Cat:Animal{
        public override void animalSound(){
            Console.WriteLine("The cat says Meow Meow.");
        }
    }

    class Program{
        static void Main(string[] args){
            Animal myAnimal = new Animal(); // Create an animal obj
            Animal myPig = new Pig();
            Animal myCat = new Cat();

            myAnimal.animalSound();
            myPig.animalSound();
            myCat.animalSound();
        }
    }
}



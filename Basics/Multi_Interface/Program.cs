using System;

namespace MyApp2{
   interface IAnimal{

    //inteface methods doesn't have body
     void sound(); 
   }

   interface IVehicle{
    void run();
   }

   class Robot: IAnimal, IVehicle { //Using 2 interfaces for a child class

        //The body for mehtods have been provided here
        public void sound(){ 
            Console.WriteLine("The robot says Oinks Oinks.");
        }

        public void run(){
            Console.WriteLine("The rbot runs fast.");
        }

    }

    class Program{
        static void Main(string[] args) {
            Robot myRobot = new Robot();
            myRobot.sound();
            myRobot.run();
        }
    }


}
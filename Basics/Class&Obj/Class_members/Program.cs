using System;

namespace MyApplication{
    class Car1{

        // Variables inside the class are called "fields" 
        //string color="blue";
        //int max_speed = 200;
        string color;
        string model;
        int max_speed;
        
        static void Main(string[] args){

            Car1 Ford = new Car1();
            Ford.color= "blue";
            Ford.max_speed= 200;
            Ford.model= "Mustang";

            Car1 Opel = new Car1();
            Opel.color= "red";
            Opel.max_speed= 300;
            Opel.model= "Astra";


            Console.WriteLine(Ford.color);
            Console.WriteLine(Ford.model);
            Console.WriteLine(Opel.max_speed);

        }       
        
    }
}
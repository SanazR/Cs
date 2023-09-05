using System;

namespace MyApplication{
    class Car{
        public string color= "red";
        public int speed= 200;
        public void fullThorottle (){
            Console.WriteLine("The car is going fast.");
        }

        static void Main(string[] atgs){
            Car myobj = new Car();
            myobj.fullThorottle();
        }

    }
}
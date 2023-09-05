using System;

namespace MyApp{
    class Program{
        static void Main(string[] args){
            Car mycar = new Car();
            mycar.honk();
            Console.WriteLine(mycar.brand + " " + mycar.model);
        }
    }
}


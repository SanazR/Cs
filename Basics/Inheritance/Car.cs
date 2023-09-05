using System;

namespace MyApp{
    class Car: Vehicle{
        public string model = "Mustang";
        
    }
}

/* If you don't want other classes to inherit from a class, 
use the sealed keyword.

sealed class Vehicle 
{
  ...
}

*/
using System;

namespace MyApplication
{
  // Create a Car class
  class Car
  {
    public string model;
    public string color;
    public int year;

    // Create a class constructor for the Car class
    /*public Car()
    {
      model = "Mustang"; // Set the initial value for model
    } */
    public Car(string modelName, string colorName, int modelYear){
        model = modelName;
        color = colorName;
        year = modelYear;
    }

    static void Main(string[] args)
    {
      // Car Ford = new Car();  // Create an object of the Car Class (this will call the constructor)
      Car Ford = new Car ("Mustang","blue", 1994);
      Car Opel = new Car("Astra", "White", 2005);
      Console.WriteLine(Ford.model + " " + Ford.year + " " + Ford.color); 
      Console.WriteLine(Opel.model + " " + Opel.year + " " + Opel.color); 
    }
  }
}
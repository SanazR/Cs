using System;

namespace MyApp
{

    class Person
    {
        public string Name  // property
        { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Person myObj = new Person();
            myObj.Name = "John";
            Console.WriteLine(myObj.Name);
        }
    }

}
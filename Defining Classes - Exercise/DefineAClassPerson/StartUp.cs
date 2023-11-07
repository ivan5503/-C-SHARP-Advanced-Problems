using Creating_Constructors;
using System;

namespace DefiningClasses
{
    public class StartUp
    {   
        static void Main(string[] args)
        {
            Person pesho = new Person();

            Console.WriteLine($"{pesho.Name} is {pesho.Age} years old");
            pesho.Name = "Pesho";
            pesho.Age = 20;

            Person niki = new Person()
            {
                Name = "Niki",
                Age = 18
            };

            Person noNameDefaultAge = new Person();
            Person noNameWithAge = new Person(25);
            Person john = new Person("John", 32);

            Console.WriteLine($"{niki.Name} is {niki.Age} years old");

            Console.WriteLine($"{noNameDefaultAge.Name} is {noNameDefaultAge.Age} years old");
            Console.WriteLine($"{noNameWithAge.Name} is {noNameWithAge.Age} years old");
            Console.WriteLine($"{john.Name} is {john.Age} years old");
        }
      
    }
}

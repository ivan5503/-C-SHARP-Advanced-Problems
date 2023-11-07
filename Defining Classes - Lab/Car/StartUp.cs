using System;
using System.Collections.Generic;
using System.Text;

namespace CarManufacturer
{
    public class StartUp
    {
        public static void Main(string[]args)
        {
            Car car = new Car();

            car.Make = "VW";
            car.Model = "Polo";
            car.Year = 8;

            Console.WriteLine($"Make: {car.Make}\nModel: {car.Model}\nYear: {car.Year}");
 
        }
    }
}

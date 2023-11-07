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
            car.FuelQuantity = 200;
            car.FuelConsumption = 2;

            car.Drive(2);
           
            Console.WriteLine(car.WhoAmI());
 
        }
    }
}

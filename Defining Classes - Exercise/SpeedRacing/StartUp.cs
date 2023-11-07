using System;
using System.Collections.Generic;
using System.Text;

namespace SpeedRacing
{
    public class StartUp
    {
        static void Main(string[]args)
        {
            List<Car> cars = new List<Car>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] currentCar = Console.ReadLine().Split();

                string model = currentCar[0];
                double fuelAmount = double.Parse(currentCar[1]);
                double fuelConsumptionPerKilometer = double.Parse(currentCar[2]);

                Car car = new Car(model, fuelAmount, fuelConsumptionPerKilometer);
                cars.Add(car);
            }

            while (true)
            {
                string[] cmdArgs = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                if (cmdArgs[0] == "End")
                {
                    break;
                }
                string command = cmdArgs[0];
                string model = cmdArgs[1];
                double amountOfKilometers = double.Parse(cmdArgs[2]);

                foreach (var car in cars)
                {
                    if (car.Model == model)
                    {
                        car.FuelCalculator(amountOfKilometers);
                    }
                }
            }
            foreach (var car in cars)
            {
                Console.WriteLine($"{car.Model} {car.FuelAmount:f2} {car.TravelledDistance}");
            }
        }
    }
}

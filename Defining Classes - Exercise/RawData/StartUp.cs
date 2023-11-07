using System;
using System.Collections.Generic;
using System.Text;

namespace RowData
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] carSpecs = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                Car car = new Car(
                     carSpecs[0],
                     int.Parse(carSpecs[1]),
                     int.Parse(carSpecs[2]),
                     int.Parse(carSpecs[3]),
                     carSpecs[4],
                     double.Parse(carSpecs[5]),
                     int.Parse(carSpecs[6]),
                     double.Parse(carSpecs[7]),
                     int.Parse(carSpecs[8]),
                     double.Parse(carSpecs[9]),
                     int.Parse(carSpecs[10]),
                     double.Parse(carSpecs[11]),
                     int.Parse(carSpecs[12])
                     );

                cars.Add(car);
            }

            string command = Console.ReadLine();
            if (command == "fragile")
            {
                List<string> carsWithFragileCargo = GetTheCarsWithPressureOfSingleTireUnder1(cars);

                foreach (var carWithFragileCargo in carsWithFragileCargo)
                {
                    Console.WriteLine(carWithFragileCargo);
                }
            }
            else if (command == "flammable")
            {
                List<string> carsWithFlammableCargo = GetTheCarsWithEnginePowerAbove250(cars);
                
                foreach (var carWithFlammableCargo in carsWithFlammableCargo)
                {
                    Console.WriteLine(carWithFlammableCargo);
                }
            }
        }

        private static List<string> GetTheCarsWithEnginePowerAbove250(List<Car> cars)
        {
            List<string> carsWithFlammableCargo = new List<string>();

            foreach (var car in cars)
            {
                if (car.Cargo.Type == "flammable")
                {
                    if (car.Engine.Power > 250)
                    {
                        carsWithFlammableCargo.Add(car.Model);
                    }
                }
            }
            return carsWithFlammableCargo;
        }

        private static List<string> GetTheCarsWithPressureOfSingleTireUnder1(List<Car> cars)
        {
            List<string> carsWithFragileCargo = new List<string>();
            foreach (var car in cars)
            {
                if (car.Cargo.Type == "fragile")
                {
                    foreach (var tire in car.Tires)
                    {
                        if (tire.Pressure < 1)
                        {
                            carsWithFragileCargo.Add(car.Model);
                            break;
                        }
                    }
                }
            }
            return carsWithFragileCargo;
        }
    }
}

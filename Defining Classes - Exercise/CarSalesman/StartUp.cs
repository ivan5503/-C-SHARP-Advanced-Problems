using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarSalesman
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();
            List<Engine> engines = new List<Engine>();

            int enginesCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < enginesCount; i++)
            {
                string[] engineSpecs = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                Engine engine = CreateEngine(engineSpecs);

                engines.Add(engine);
            }

            int countOfCars = int.Parse(Console.ReadLine());
            
            for (int i = 0; i < countOfCars; i++)
            {
                string[] carSpecs = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                Car car = CreateCar(carSpecs,engines);

                cars.Add(car);
            }
            foreach (var car in cars)
            {
                Console.WriteLine(car.ToString());
            }
        }

        static Car CreateCar(string[] carSpecs, List<Engine> engines)
        {
            string model = carSpecs[0];
            Engine engine = engines
                .Where(e => e.Model == carSpecs[1])
                .FirstOrDefault();
            Car car = new Car(model, engine);

            if (carSpecs.Length > 2)
            {
                int weight;
                bool isDigit = int.TryParse(carSpecs[2], out weight);
                if (isDigit)
                {
                    car.Weight = weight;
                }
                else
                {
                    car.Color = carSpecs[2];
                }
            }
            if (carSpecs.Length > 3)
            {
                car.Color = carSpecs[3];
            }
            return car; 
        }

        static Engine CreateEngine(string[] engineSpecs)
        {
            Engine engine = new Engine(engineSpecs[0], int.Parse(engineSpecs[1]));

            if (engineSpecs.Length > 2)
            {
                int displacement;

                bool isDigit = int.TryParse(engineSpecs[2], out displacement);

                if (isDigit)
                {
                    engine.Displacement = displacement;
                }
                else
                {
                    engine.Efficiency = engineSpecs[2];
                }
            }
            if (engineSpecs.Length > 3)
            {
                engine.Efficiency = engineSpecs[3];
            }
            return engine;
        }
    }
}

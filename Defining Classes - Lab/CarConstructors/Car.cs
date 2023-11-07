using System;
using System.Collections.Generic;
using System.Text;

namespace CarManufacturer
{
    class Car
    {
        private string make;
        private string model;
        private int year;
        private double fuelQuantity;
        private double fuelConsumption;

        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public double FuelQuantity { get; set; }
        public double FuelConsumption { get; set; }

        public Car()
        {
            this.Make = "VW";
            this.Model = "Golf";
            this.Year = 2025;
            this.FuelQuantity = 200;
            this.FuelConsumption = 10;
        }
        public Car(string make, string model, int year)
        : this()
        {
            this.Make = make;
            this.Model = model;
            this.Year = year;
        }
        public Car(string make, string model, int year, double fuelQuantity, double fuelConsumption)
        : this(make, model, year)
        {
            this.FuelQuantity = fuelQuantity;
            this.FuelConsumption = fuelConsumption;
        }
        public void Drive(double distance)
        {
            double neededFuel = FuelQuantity - FuelConsumption * distance;
            if (neededFuel > 0)
            {
                FuelQuantity -= FuelConsumption * distance;
            }
            else
            {
                Console.WriteLine($"Not enough fuel to perform this trip!");
            }
        }
        public string WhoAmI()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append($"Make: {this.Make}{Environment.NewLine}");
            sb.Append($"Model: { this.Model}{Environment.NewLine}");
            sb.Append($"Year: { this.Year}{Environment.NewLine}");
            sb.Append($"Fuel: { this.FuelQuantity:F2}{Environment.NewLine}");

            return sb.ToString().Trim();

        }
    }
}

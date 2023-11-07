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

        public void Drive(double distance)
        {
            double result = FuelQuantity - FuelConsumption * distance;
            if (result > 0)
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


using System;

namespace CarSalesman
{
    public class Engine
    {
        string model;
        int power;
        int displacement;
        string efficiency;

        public Engine(string model, int power)
        {
            Model = model;
            Power = power;
        }

        public string Model { get { return model; }set { model = value; } }
        public int Power { get { return power; }set { power = value; } }
        public int Displacement { get { return displacement; }set { displacement = value; } }
        public string Efficiency { get { return efficiency; }set { efficiency = value; } }

        public override string ToString()
        {
            string displacement = Displacement == 0 ? "n/a" : Displacement.ToString();
            string efficiency = Efficiency ?? "n/a";

            string result =
                $"{Model}:{Environment.NewLine}" +
                $"    Power: {Power}{Environment.NewLine}" +
                $"    Displacement: {displacement}{Environment.NewLine}" +
                $"    Efficiency: {efficiency}";
                
            return result;
        }
    }
}

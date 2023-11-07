﻿
using System;

namespace CarSalesman
{
    public class Car
    {
        string model;
        Engine engine;
        int weight;
        string color;

        public Car(string model,Engine engine)
        {
            Model = model;
            Engine = engine;
        }

        public string Model { get { return model; }set { model = value; } }
        public Engine Engine { get { return engine; }set { engine = value; } }
        public int Weight { get { return weight; }set { weight = value; } }
        public string Color { get { return color; }set { color = value; } }
        public override string ToString()
        {
            string weight = Weight == 0 ? "n/a" : Weight.ToString();
            string color = Color ?? "n/a";

            string result =
                $"{Model}:{Environment.NewLine}" +
                $"  {Engine.ToString()}{Environment.NewLine}" +
                $"  Weight: {weight}{Environment.NewLine}" +
                $"  Color: {color}";

            return result;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;

namespace OpinionPoll
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            List<Person> peopleOver30 = new List<Person>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string name = input[0];
                int age = int.Parse(input[1]);

                person = new Person(name, age);
                if (age > 30)
                {
                   peopleOver30.Add(person);
                }
            }

            foreach (var p in peopleOver30.OrderBy(p => p.Name))
            {
                Console.WriteLine($"{p.Name} - {p.Age}");
            }
        }
    }
}

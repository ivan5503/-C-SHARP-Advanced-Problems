using System;
using System.Collections.Generic;
using System.Linq;

namespace Monster_Extermination
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> armorValues = new Queue<int>(Console.ReadLine().Split(",").Select(int.Parse));
            Stack<int> strikingImpactValues = new Stack<int>(Console.ReadLine().Split(",").Select(int.Parse));

            int countMonsters = armorValues.Count;

            while (armorValues.Any() && strikingImpactValues.Any())
            {
                int currentArmorValue = armorValues.Peek();
                int currentStrikingImpactValue = strikingImpactValues.Peek();

                if (currentStrikingImpactValue > currentArmorValue)
                {
                    armorValues.Dequeue();
                    int remainingImpactValue = currentStrikingImpactValue - currentArmorValue;
                    strikingImpactValues.Pop();
                    if (strikingImpactValues.Any())
                    {
                        int nextElement = strikingImpactValues.Peek();
                        nextElement = nextElement + remainingImpactValue;
                        strikingImpactValues.Pop();
                        strikingImpactValues.Push(nextElement);
                    }
                    else
                    {
                        strikingImpactValues.Push(remainingImpactValue);
                    }
                }
                else if (currentStrikingImpactValue == currentArmorValue)
                {
                    armorValues.Dequeue();
                    strikingImpactValues.Pop();
                }
                else
                {
                    strikingImpactValues.Pop();
                    int remainingArmorValue = Math.Abs(currentStrikingImpactValue - currentArmorValue);
                    armorValues.Dequeue();
                    armorValues.Enqueue(remainingArmorValue);
                }
            }

            if (!armorValues.Any())
            {
                Console.WriteLine($"All monsters have been killed!");
            }
            if (!strikingImpactValues.Any())
            {
                Console.WriteLine($"The soldier has been defeated.");
            }
            Console.WriteLine($"Total monsters killed: {countMonsters - armorValues.Count}");
        }
    }
}

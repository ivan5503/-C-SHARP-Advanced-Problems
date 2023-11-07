int[] setsLength = Console.ReadLine()
       .Split(" ", StringSplitOptions.RemoveEmptyEntries)
       .Select(int.Parse)
       .ToArray();

HashSet<int> firstSetOfNumbers = new HashSet<int>();
HashSet<int> secondSetOfNumbers = new HashSet<int>();

for (int i = 0; i < setsLength[0]; i++)
{
    firstSetOfNumbers.Add(int.Parse(Console.ReadLine()));
}
for (int j = 0; j < setsLength[1]; j++)
{
    secondSetOfNumbers.Add(int.Parse(Console.ReadLine()));
}
firstSetOfNumbers.IntersectWith(secondSetOfNumbers);
Console.WriteLine(string.Join(" ", firstSetOfNumbers));

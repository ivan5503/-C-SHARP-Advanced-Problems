List<int> numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
   .Select(int.Parse)
   .ToList();

int[] sorted = numbers.OrderByDescending(x => x).ToArray();
int index = 1;
for (int i = 0; i < sorted.Length; i++)
{
    Console.Write($"{sorted[i]} ");
    if (index == 3)
    {
        break;
    }
    index++;
}

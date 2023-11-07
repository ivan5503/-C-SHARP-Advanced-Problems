int[] elements = Console.ReadLine()
   .Split()
   .Select(int.Parse)
   .ToArray();

int nTimesToEnque = elements[0];
int nTimesToDeque = elements[1];
int soughtForNumber = elements[2];

int[] integers = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();

Queue<int> queue = new Queue<int>();
for (int i = 0; i < nTimesToEnque; i++)
{
    queue.Enqueue(integers[i]);
}
for (int j = 0; j < nTimesToDeque; j++)
{
    queue.Dequeue();
}
if (!queue.Any())
{
    Console.WriteLine(0);
}
else
{
    if (queue.Contains(soughtForNumber))
    {
        Console.WriteLine("true");
    }
    else
    {
        Console.WriteLine(queue.Min());
    }
}

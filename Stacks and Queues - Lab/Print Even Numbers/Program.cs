Queue<int> queue = new Queue<int>();
int[] numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

foreach (var num in numbers)
{
    if (num % 2 == 0)
    {
        queue.Enqueue(num);
    }
}
while (queue.Count > 1)
{
    Console.Write($"{queue.Dequeue()}, ");
}
Console.WriteLine(queue.Dequeue());

Queue<string> queue = new Queue<string>();

string[] names = Console.ReadLine().Split(" ");
int nToss = int.Parse(Console.ReadLine());

foreach (var name in names)
{
    queue.Enqueue(name);
}
int index = 0;
while (queue.Count > 1)
{
    string currentName = queue.Dequeue();
    index++;
    if (index == nToss)
    {
        Console.WriteLine($"Removed {currentName}");
        index = 0;
    }
    else
    {
        queue.Enqueue(currentName);
    }
}
Console.WriteLine($"Last is {queue.Peek()}");

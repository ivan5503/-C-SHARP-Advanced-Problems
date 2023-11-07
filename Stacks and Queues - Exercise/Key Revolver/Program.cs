int bulletPrice = int.Parse(Console.ReadLine());
int barrelSize = int.Parse(Console.ReadLine());

Stack<int> bullets = new Stack<int>(Console.ReadLine().Split(" ").Select(int.Parse));
Queue<int> locks = new Queue<int>(Console.ReadLine().Split(" ").Select(int.Parse));

int intelligence = int.Parse(Console.ReadLine());

int bulletsInitialCount = bullets.Count();

int fiered = barrelSize;
bool isTheSafeOpen = false;

while (bullets.Count > 0 && locks.Count > 0)
{
    fiered--;

    if (bullets.Pop() <= locks.Peek())
    {
        Console.WriteLine("Bang!");
        locks.Dequeue();
        if (locks.Count == 0)
        {
            isTheSafeOpen = true;
        }
    }
    else
    {
        Console.WriteLine("Ping!");
    }
    if (fiered == 0 && bullets.Any())
    {
        Console.WriteLine("Reloading!");
        fiered = barrelSize;
    }
}
if (isTheSafeOpen)
{
    Console.WriteLine($"{bullets.Count} bullets left. Earned $" +
        $"{intelligence - ((bulletsInitialCount - bullets.Count) * bulletPrice)}");
}
else
{
    Console.WriteLine($"Couldn't get through. Locks left: {locks.Count}");
}

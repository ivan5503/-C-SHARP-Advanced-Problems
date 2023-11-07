int foodQuantity = int.Parse(Console.ReadLine());

int[] quantityOfOrders = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();

Queue<int> queueOfOrders = new Queue<int>();
foreach (var quantityOfOrder in quantityOfOrders)
{
    queueOfOrders.Enqueue(quantityOfOrder);
}
int biggestOrder = queueOfOrders.Max();
Console.WriteLine(biggestOrder);

while (queueOfOrders.Count > 0)
{
    int currentOrder = queueOfOrders.Peek();

    foodQuantity -= currentOrder;
    if (foodQuantity < 0)
    {
        Console.WriteLine($"Orders left: {string.Join(" ", queueOfOrders)}");
        foodQuantity += currentOrder;
        return;
    }
    queueOfOrders.Dequeue();
}
Console.WriteLine("Orders complete");

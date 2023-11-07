Queue<string> queue = new Queue<string>();

string input = string.Empty;

while ((input = Console.ReadLine()) != "End")
{
    string command = input;

    if (command == "Paid")
    {
        while (queue.Count > 0)
        {
            Console.WriteLine(queue.Dequeue());
        }
    }
    else
    {
        string customerName = input;
        queue.Enqueue(customerName);
    }
}
Console.WriteLine($"{queue.Count} people remaining.");

Queue<string> queue = new Queue<string>(Console.ReadLine()
      .Split(", ", StringSplitOptions.RemoveEmptyEntries));

while (queue.Count > 0)
{
    string[] cmdArgs = Console.ReadLine().Split();
    string command = cmdArgs[0];

    switch (command)
    {
        case "Play":
            queue.Dequeue();
            break;
        case "Add":
            string song = string.Join(" ", cmdArgs.Skip(1));
            if (!queue.Contains(song))
            {
                queue.Enqueue(song);
            }
            else
            {
                Console.WriteLine($"{song} is already contained!");
            }
            break;
        case "Show":
            Console.WriteLine(string.Join(", ", queue));
            break;

    }
}
Console.WriteLine("No more songs!");

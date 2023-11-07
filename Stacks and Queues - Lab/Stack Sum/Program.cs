int[] input = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

Stack<int> stack = new Stack<int>();

for (int i = 0; i < input.Length; i++)
{
    stack.Push(input[i]);
}

while (true)
{
    string[] splitted = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

    string command = splitted[0].ToLower();
    if (command == "end")
    {
        break;
    }

    switch (command)
    {
        case "add":
            int num1 = int.Parse(splitted[1]);
            int num2 = int.Parse(splitted[2]);

            stack.Push(num1);
            stack.Push(num2);
            break;
        case "remove":
            num1 = int.Parse(splitted[1]);

            if (stack.Count >= num1)
            {
                for (int i = 0; i < num1; i++)
                {
                    stack.Pop();
                }
            }
            break;
    }
}
Console.WriteLine($"Sum: {stack.Sum()}");

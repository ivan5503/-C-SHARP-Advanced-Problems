Stack<int> stack = new Stack<int>();

int n = int.Parse(Console.ReadLine());

int push = 1; int delete = 2;
int printMaximum = 3; int printMinimum = 4;

for (int i = 0; i < n; i++)
{
    int[] queries = Console.ReadLine().Split().Select(int.Parse).ToArray();

    int command = queries[0];

    if (command == push)
    {
        int element = queries[1];
        stack.Push(element);
    }
    else if (command == delete)
    {
        if (stack.Any())
        {
            stack.Pop();
        }
    }
    else if (command == printMaximum)
    {
        if (stack.Any())
        {
            Console.WriteLine(stack.Max());
        }
    }
    else if (command == printMinimum)
    {
        if (stack.Any())
        {
            Console.WriteLine(stack.Min());
        }
    }
}
if (stack.Any())
{
    while (stack.Count > 1)
    {
        Console.Write($"{stack.Pop()}, ");
    }
    Console.WriteLine(stack.Pop());
}

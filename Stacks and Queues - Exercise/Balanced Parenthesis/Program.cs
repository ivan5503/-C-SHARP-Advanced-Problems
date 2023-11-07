string sequenceOfParentheses = Console.ReadLine();

Stack<char> stack = new Stack<char>();

bool isBalanced = true;
foreach (var current in sequenceOfParentheses)
{
    if (current == '{' || current == '[' || current == '(')
    {
        stack.Push(current);
    }
    else
    {
        if (stack.Count == 0)
        {
            isBalanced = false;
            break;
        }
        char last = stack.Peek();
        if (last == '{' && current == '}')
        {
            stack.Pop();
        }
        else if (last == '[' && current == ']')
        {
            stack.Pop();
        }
        else if (last == '(' && current == ')')
        {
            stack.Pop();
        }
        else
        {
            isBalanced = false;
        }
    }
}
if (isBalanced)
{
    Console.WriteLine("YES");
}
else
{
    Console.WriteLine("NO");
}

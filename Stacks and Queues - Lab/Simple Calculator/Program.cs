Stack<string> stack = new Stack<string>();
string input = Console.ReadLine();

string[] tokens = input.Split(" ");
foreach (var token in tokens)
{
    stack.Push(token);
}

int result = 0;
int num = 0;
string mathOperator = string.Empty;
while (stack.Count > 0)
{
    string current = stack.Peek();
    if (current == "+" || current == "-")
    {
        mathOperator = stack.Pop();
    }
    else
    {
        num = int.Parse(stack.Pop());
    }

    if (mathOperator == "+")
    {
        result += num;
        num = 0;
        mathOperator = string.Empty;
    }
    if (mathOperator == "-")
    {
        result -= num;
        num = 0;
        mathOperator = string.Empty;
    }
}
result = result + num;
Console.WriteLine(result);

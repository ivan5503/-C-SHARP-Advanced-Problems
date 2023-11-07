using System.Text;

int n = int.Parse(Console.ReadLine());

Stack<int> commands = new Stack<int>();
Stack<string> texts = new Stack<string>();

StringBuilder sb = new StringBuilder();

int Append = 1; int Erase = 2;
int Print = 3; int UndoLastUpdate = 4;

for (int i = 0; i < n; i++)
{
    string[] tokens = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
    int command = int.Parse(tokens[0]);

    if (command == Append)
    {
        string text = tokens[1];

        sb.Append(text);
        texts.Push(text);
        commands.Push(Append);
    }
    else if (command == Erase)
    {
        int count = int.Parse(tokens[1]);
        if (count > sb.Length)
        {
            continue;
        }

        int startIndex = sb.Length - count;
        int endIndex = sb.Length - 1;

        string temp = string.Empty;
        for (int s = startIndex; s <= endIndex; s++)
        {
            temp += sb[s].ToString();
        }
        texts.Push(temp);
        commands.Push(Erase);

        sb.Remove(startIndex, endIndex - startIndex + 1);
    }
    else if (command == Print)
    {
        int index = int.Parse(tokens[1]) - 1;
        if (!(index >= 0 && index < sb.Length))
        {
            continue;
        }
        Console.WriteLine(sb[index]);
    }
    else if (command == UndoLastUpdate)
    {
        string lastTextUpdate = texts.Peek();
        int lastCommandUpdate = commands.Peek();

        if (lastCommandUpdate == 1)
        {
            string temp = sb.ToString();

            int startIndex = temp.LastIndexOf(lastTextUpdate);
            int endIndex = startIndex + lastTextUpdate.Length - 1;

            sb.Remove(startIndex, endIndex - startIndex + 1);
        }
        else if (lastCommandUpdate == 2)
        {
            sb.Append(lastTextUpdate);
        }
        texts.Pop();
        commands.Pop();
    }
}

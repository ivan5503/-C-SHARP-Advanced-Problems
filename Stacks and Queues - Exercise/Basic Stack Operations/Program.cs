Stack<int> stack = new Stack<int>();

int[] cmdValues = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

int numberOfElementsToPush = cmdValues[0];
int numberOfElementsToPop = cmdValues[1];
int elementToLookFor = cmdValues[2];

int[] elementsToManipulate = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

for (int i = 0; i < numberOfElementsToPush; i++)
{
    stack.Push(elementsToManipulate[i]);
}
for (int j = 0; j < numberOfElementsToPop; j++)
{
    stack.Pop();
}
if (stack.Count == 0)
{
    Console.WriteLine(0);
}
else
{
    bool isTheElementFound = false;
    foreach (var element in stack)
    {
        if (element == elementToLookFor)
        {
            Console.WriteLine("true");
            isTheElementFound = true;
            break;
        }
    }
    if (!isTheElementFound)
    {
        int minValue = int.MaxValue;
        foreach (var element in stack)
        {
            if (element < minValue)
            {
                minValue = element;
            }
        }
        Console.WriteLine(minValue);
    }
}

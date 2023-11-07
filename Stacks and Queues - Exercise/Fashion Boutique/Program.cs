int[] clothesInTheBox = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();

Stack<int> stackOfClothes = new Stack<int>();

foreach (var cloth in clothesInTheBox)
{
    stackOfClothes.Push(cloth);
}

int capacityOfTheRack = int.Parse(Console.ReadLine());
int sumOfClothes = 0;
int racks = 0;
while (stackOfClothes.Count > 0)
{
    int currentCloth = stackOfClothes.Peek();
    sumOfClothes += currentCloth;
    if (sumOfClothes == capacityOfTheRack)
    {
        sumOfClothes = 0;
        racks++;
    }
    else if (sumOfClothes > capacityOfTheRack)
    {
        sumOfClothes = 0;
        racks++;
        continue;
    }

    stackOfClothes.Pop();
}
if (sumOfClothes > 0)
{
    racks++;
}
Console.WriteLine(racks);
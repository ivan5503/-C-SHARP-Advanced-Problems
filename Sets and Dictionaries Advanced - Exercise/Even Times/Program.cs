
int n = int.Parse(Console.ReadLine());

Dictionary<int, int> collection = new Dictionary<int, int>();

for (int i = 0; i < n; i++)
{
    int number = int.Parse(Console.ReadLine());
    if (!collection.ContainsKey(number))
    {
        collection.Add(number, 0);
    }
    collection[number]++;
}
Console.WriteLine(collection.Single(n => n.Value % 2 == 0).Key);
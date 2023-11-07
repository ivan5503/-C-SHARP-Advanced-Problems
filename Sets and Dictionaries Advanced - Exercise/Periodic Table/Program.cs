int n = int.Parse(Console.ReadLine());

SortedSet<string> periodicTable = new SortedSet<string>();

for (int i = 0; i < n; i++)
{
    List<string> chemicalCompounds = Console.ReadLine()
        .Split(" ", StringSplitOptions.RemoveEmptyEntries)
        .ToList();

    periodicTable.UnionWith(chemicalCompounds);
}
Console.WriteLine(string.Join(" ", periodicTable));

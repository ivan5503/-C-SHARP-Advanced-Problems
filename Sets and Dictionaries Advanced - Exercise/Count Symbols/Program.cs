string text = Console.ReadLine();

SortedDictionary<char, int> occurrancesOfEachChar = new SortedDictionary<char, int>();

for (int i = 0; i < text.Length; i++)
{
    char ch = text[i];

    if (!occurrancesOfEachChar.ContainsKey(ch))
    {
        occurrancesOfEachChar.Add(ch, 0);
    }
    occurrancesOfEachChar[ch]++;
}
foreach (var element in occurrancesOfEachChar)
{
    Console.WriteLine($"{element.Key}: {element.Value} time/s");
}

int n = int.Parse(Console.ReadLine());

Dictionary<string, Dictionary<string, int>> clothesByColor
    = new Dictionary<string, Dictionary<string, int>>();

string currentItem = string.Empty;
for (int i = 0; i < n; i++)
{
    string[] items = Console.ReadLine()
        .Split(new string[] { " -> ", "," }, StringSplitOptions.RemoveEmptyEntries);
    string color = items[0];

    if (!clothesByColor.ContainsKey(color))
    {
        clothesByColor.Add(color, new Dictionary<string, int>());
    }
    for (int j = 1; j < items.Length; j++)
    {
        currentItem = items[j];

        if (!clothesByColor[color].ContainsKey(currentItem))
        {
            clothesByColor[color].Add(currentItem, 0);
        }
        clothesByColor[color][currentItem]++;
    }

}
string[] desiredItems = Console.ReadLine().Split(" ");
string desiredColor = desiredItems[0];
string desiredClothing = desiredItems[1];

foreach (var clothes in clothesByColor)
{
    Console.WriteLine($"{clothes.Key} clothes:");

    foreach (var item in clothes.Value)
    {
        if (desiredColor == clothes.Key && desiredClothing == item.Key)
        {
            Console.WriteLine($"* {item.Key} - {item.Value} (found!)");
        }
        else
        {
            Console.WriteLine($"* {item.Key} - {item.Value}");
        }
    }
}

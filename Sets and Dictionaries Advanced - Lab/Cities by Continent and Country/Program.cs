int nLines = int.Parse(Console.ReadLine());

Dictionary<string, Dictionary<string, List<string>>> continents =
    new Dictionary<string, Dictionary<string, List<string>>>();


string input = string.Empty;
for (int i = 0; i < nLines; i++)
{
    input = Console.ReadLine();
    string[] splitted = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
    string continent = splitted[0];
    string country = splitted[1];
    string city = splitted[2];

    if (!continents.ContainsKey(continent))
    {
        continents.Add(continent, new Dictionary<string, List<string>>());
    }
    if (!continents[continent].ContainsKey(country))
    {
        continents[continent].Add(country, new List<string>());
    }
    continents[continent][country].Add(city);
}
foreach (var continent in continents)
{
    Console.WriteLine($"{continent.Key}:");
    foreach (var country in continent.Value)
    {
        Console.WriteLine($"  {country.Key} -> {string.Join(", ", country.Value)}");
    }
}

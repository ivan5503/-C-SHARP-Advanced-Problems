
Dictionary<double, int> values = new Dictionary<double, int>();

double[] valuesInArray = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(double.Parse)
    .ToArray();

for (int i = 0; i < valuesInArray.Length; i++)
{
    double currentValue = valuesInArray[i];
    if (!values.ContainsKey(currentValue))
    {
        values.Add(currentValue, 0);
    }
    values[currentValue]++;
}
foreach (var value in values)
{
    Console.WriteLine($"{value.Key} - {value.Value} times");
}
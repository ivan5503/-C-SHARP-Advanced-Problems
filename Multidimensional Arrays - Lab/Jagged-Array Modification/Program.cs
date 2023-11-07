int rows = int.Parse(Console.ReadLine());
int[][] jaggedArr = new int[rows][];
for (int row = 0; row < rows; row++)
{
    jaggedArr[row] = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

}

string input = string.Empty;

while ((input = Console.ReadLine()) != "END")
{
    string[] tokens = input.Split();

    string command = tokens[0];
    int row = int.Parse(tokens[1]);
    int col = int.Parse(tokens[2]);
    int value = int.Parse(tokens[3]);

    if (!(row >= 0 && row < jaggedArr.Length && col >= 0 && col < jaggedArr[row].Length))
    {
        Console.WriteLine("Invalid coordinates");
    }
    else if (command == "Add")
    {
        jaggedArr[row][col] += value;
    }
    else
    {
        jaggedArr[row][col] -= value;
    }
}
foreach (var array in jaggedArr)
{
    Console.WriteLine(string.Join(" ", array));
}

int rows = int.Parse(Console.ReadLine());

long[][] pascalTriangle = new long[rows][];

for (int row = 0; row < pascalTriangle.Length; row++)
{
    pascalTriangle[row] = new long[row + 1];
    for (int col = 0; col < pascalTriangle[row].Length; col++)
    {
        if (col == 0 || col == pascalTriangle[row].Length - 1)
        {
            pascalTriangle[row][col] = 1;
        }
        else
        {
            pascalTriangle[row][col] = pascalTriangle[row - 1][col - 1] + pascalTriangle[row - 1][col];
        }
    }
}
foreach (var currentRow in pascalTriangle)
{
    Console.WriteLine(string.Join(" ", currentRow));
}

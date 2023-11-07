
int[] dimensions = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();

int rows = dimensions[0];
int cols = dimensions[1];

int[,] matrix = new int[rows, cols];

for (int row = 0; row < matrix.GetLength(0); row++)
{
    int[] numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
        .Select(int.Parse)
        .ToArray();
    for (int col = 0; col < matrix.GetLength(1); col++)
    {
        matrix[row, col] = numbers[col];
    }
}
for (int col = 0; col < matrix.GetLength(1); col++)
{
    int columnSum = 0;
    for (int row = 0; row < matrix.GetLength(0); row++)
    {
        columnSum += matrix[row, col];
    }
    Console.WriteLine(columnSum);
}
Console.WriteLine();

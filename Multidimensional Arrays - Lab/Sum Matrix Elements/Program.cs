﻿int[] dimensions = Console.ReadLine().Split(", ").Select(int.Parse)
    .ToArray();

int rows = dimensions[0];
int cols = dimensions[1];
int[,] matrix = new int[rows, cols];
int sum = 0;

for (int row = 0; row < matrix.GetLength(0); row++)
{
    int[] numbers = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries)
        .Select(int.Parse).ToArray();
    for (int col = 0; col < matrix.GetLength(1); col++)
    {
        matrix[row, col] = numbers[col];
        sum += matrix[row, col];
    }
}
Console.WriteLine(rows);
Console.WriteLine(cols);
Console.WriteLine(sum);

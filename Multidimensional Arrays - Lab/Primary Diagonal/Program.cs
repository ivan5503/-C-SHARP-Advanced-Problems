﻿int size = int.Parse(Console.ReadLine());
int rows = size;
int cols = size;

int[,] matrix = new int[rows, cols];

for (int row = 0; row < rows; row++)
{
    int[] numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
        .Select(int.Parse)
        .ToArray();
    for (int col = 0; col < cols; col++)
    {
        matrix[row, col] = numbers[col];
    }
}
int sumPrimaryDiagonal = 0;
for (int i = 0; i < matrix.GetLength(0); i++)
{
    sumPrimaryDiagonal += matrix[i, i];
}
Console.WriteLine(sumPrimaryDiagonal);

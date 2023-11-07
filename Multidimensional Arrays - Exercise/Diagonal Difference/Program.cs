int n = int.Parse(Console.ReadLine());

int[,] matrix = new int[n, n];

for (int row = 0; row < matrix.GetLength(0); row++)
{
    int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
    for (int col = 0; col < matrix.GetLength(1); col++)
    {
        matrix[row, col] = numbers[col];
    }
}
int primaryDiagonal = 0;
int secondaryDiagonal = 0;

for (int i = 0; i < n; i++)
{
    primaryDiagonal += matrix[i, i];
    secondaryDiagonal += matrix[i, n - 1 - i];
}
Console.WriteLine($"{Math.Abs(primaryDiagonal - secondaryDiagonal)}");

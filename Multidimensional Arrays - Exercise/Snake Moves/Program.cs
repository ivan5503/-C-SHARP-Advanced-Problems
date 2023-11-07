string[] dimensions = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

int rows = int.Parse(dimensions[0]);
int cols = int.Parse(dimensions[1]);

string snake = Console.ReadLine();
char[,] matrix = new char[rows, cols];

int i = -1;
for (int row = 0; row < rows; row++)
{
    for (int col = 0; col < cols; col++)
    {
        if (i == snake.Length - 1)
        {
            i = -1;
        }
        i++;
        if (row % 2 == 0)
        {
            matrix[row, col] = snake[i];
        }
        else
        {
            matrix[row, cols - 1 - col] = snake[i];
        }
    }
}
for (int row = 0; row < rows; row++)
{
    for (int col = 0; col < cols; col++)
    {
        Console.Write($"{matrix[row, col]}");
    }
    Console.WriteLine();
}

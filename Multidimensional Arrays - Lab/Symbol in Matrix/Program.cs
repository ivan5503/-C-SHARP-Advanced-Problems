int size = int.Parse(Console.ReadLine());

int rows = size;
int cols = rows;

char[,] matrix = new char[rows, cols];

for (int row = 0; row < rows; row++)
{
    string input = Console.ReadLine();
    for (int col = 0; col < cols; col++)
    {
        matrix[row, col] = input[col];
    }
}
char symbol = char.Parse(Console.ReadLine());

for (int row = 0; row < rows; row++)
{
    for (int col = 0; col < cols; col++)
    {
        if (symbol == matrix[row, col])
        {
            Console.WriteLine($"({row}, {col})");
            return;
        }
    }
}
Console.WriteLine($"{symbol} does not occur in the matrix");

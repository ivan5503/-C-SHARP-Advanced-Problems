namespace Matrix_Shuffling 
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dimensions = Console.ReadLine().Split().Select(int.Parse).ToArray();

            string[,] matrix = new string[dimensions[0], dimensions[1]];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string[] data = Console.ReadLine().Split();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = data[col];
                }
            }
            string input = string.Empty;
            while ((input = Console.ReadLine()) != "END")
            {
                string[] splitted = input.Split();
                string command = splitted[0];

                if (command != "swap" || splitted.Length != 5)
                {
                    Console.WriteLine("Invalid input!");
                }
                else
                {
                    int row1 = int.Parse(splitted[1]);
                    int col1 = int.Parse(splitted[2]);
                    int row2 = int.Parse(splitted[3]);
                    int col2 = int.Parse(splitted[4]);

                    if (!(row1 >= 0 && row1 < matrix.GetLength(0) && row2 >= 0 && row2 < matrix.GetLength(0) &&
                        col1 >= 0 && col1 < matrix.GetLength(1) && col2 >= 0 && col2 < matrix.GetLength(1)))
                    {
                        Console.WriteLine("Invalid input!");
                    }
                    else
                    {
                        string temp = string.Empty;
                        temp = matrix[row1, col1];
                        matrix[row1, col1] = matrix[row2, col2];
                        matrix[row2, col2] = temp;

                        PrintMatrix(matrix);
                    }
                }
            }
        }

        private static void PrintMatrix(string[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write($"{matrix[row, col]} ");
                }
                Console.WriteLine();
            }
        }
    }
}

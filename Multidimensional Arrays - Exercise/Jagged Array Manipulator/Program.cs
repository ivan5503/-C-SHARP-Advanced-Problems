using System;
using System.Linq;

namespace demo
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());

            int[][] jaggedArray = new int[rows][];

            for (int row = 0; row < jaggedArray.Length; row++)
            {
                jaggedArray[row] = Console.ReadLine().Split().Select(int.Parse).ToArray();

            }
            for (int row = 0; row < jaggedArray.Length - 1; row++)
            {
                if (jaggedArray[row].Length == jaggedArray[row + 1].Length)
                {
                    MultiplyOrDivide(jaggedArray, row, '*');
                }
                else
                {
                    MultiplyOrDivide(jaggedArray, row, '/');
                }
            }
            string input = string.Empty;
            while ((input = Console.ReadLine()) != "End")
            {
                string[] splitted = input.Split();

                string command = splitted[0];

                int row = int.Parse(splitted[1]);
                int col = int.Parse(splitted[2]);
                int value = int.Parse(splitted[3]);

                if (isValid(jaggedArray, row, col))
                {
                    if (command == "Add")
                    {
                        jaggedArray[row][col] += value;
                    }
                    else
                    {
                        jaggedArray[row][col] -= value;
                    }
                }
            }
            Print(jaggedArray);
        }

        private static void Print(int[][] jaggedArray)
        {
            for (int row = 0; row < jaggedArray.Length; row++)
            {
                for (int col = 0; col < jaggedArray[row].Length; col++)
                {
                    Console.Write($"{jaggedArray[row][col]} ");
                }
                Console.WriteLine();
            }
        }

        private static bool isValid(int[][] jagged, int row, int col)
        {
            return
                row >= 0 && row < jagged.Length
                && col >= 0 && col < jagged[row].Length;
        }

        private static void MultiplyOrDivide(int[][] jagged, int index, char symbol)
        {
            if (symbol == '*')
            {
                for (int row = index; row <= index + 1; row++)
                {
                    for (int col = 0; col < jagged[row].Length; col++)
                    {
                        jagged[row][col] *= 2;
                    }
                }
            }
            else
            {
                for (int row = index; row <= index + 1; row++)
                {
                    for (int col = 0; col < jagged[row].Length; col++)
                    {
                        jagged[row][col] /= 2;
                    }
                }
            }
        }
    }
}


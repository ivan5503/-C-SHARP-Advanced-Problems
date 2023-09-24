using System;
using System.Collections.Generic;
using System.Linq;

namespace Delivery_Boy
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dimensions = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();
            int rows = dimensions[0];
            int cols = dimensions[1];

            char[,] matrix = new char[rows, cols];

            int deliveryCurrentPositionRow = 0;
            int deliveryCurrentPositionCol = 0;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string rowData = Console.ReadLine();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = rowData[col];
                    if (matrix[row, col] == 'B')
                    {
                        deliveryCurrentPositionRow = row;
                        deliveryCurrentPositionCol = col;
                    }
                }
            }

            int initialPositionRow = deliveryCurrentPositionRow;
            int initialPositionCol = deliveryCurrentPositionCol;
            while (true)
            {
                bool isTheDeliveryOnTime = false;

                string command = Console.ReadLine();

                int previousPositionRow = deliveryCurrentPositionRow;
                int previousPositionCol = deliveryCurrentPositionCol;
                switch (command)
                {
                    case "up":
                        deliveryCurrentPositionRow--;
                        break;
                    case "down":
                        deliveryCurrentPositionRow++;
                        break;
                    case "left":
                        deliveryCurrentPositionCol--;
                        break;
                    case "right":
                        deliveryCurrentPositionCol++;
                        break;
                }

                isTheDeliveryOnTime = CheckWhetherThePositionIsValid(deliveryCurrentPositionRow, deliveryCurrentPositionCol, rows, cols);
                if (isTheDeliveryOnTime)
                {
                    if (matrix[deliveryCurrentPositionRow, deliveryCurrentPositionCol] == '*')
                    {
                        deliveryCurrentPositionRow = previousPositionRow;
                        deliveryCurrentPositionCol = previousPositionCol;
                        continue;
                    }
                        matrix = Move(matrix, deliveryCurrentPositionRow, deliveryCurrentPositionCol);
                }
                if (!isTheDeliveryOnTime)
                {
                    Console.WriteLine($"The delivery is late. Order is canceled.");
                    matrix[initialPositionRow, initialPositionCol] = ' ';
                    break;
                }
                else if (matrix[deliveryCurrentPositionRow, deliveryCurrentPositionCol] == 'R')
                {
                    Console.WriteLine($"Pizza is collected. 10 minutes for delivery.");
                }
                else if (matrix[deliveryCurrentPositionRow, deliveryCurrentPositionCol] == 'P')
                {
                    Console.WriteLine($"Pizza is delivered on time! Next order...");
                    break;
                }
            }
            PrintMatrix(matrix);
        }

        static void PrintMatrix(char[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col]);
                }
                Console.WriteLine();
            }
        }

        static bool CheckWhetherThePositionIsValid(int currentRow, int currentCol, int rows, int cols)
        {
            return
            currentRow >= 0
            && currentRow < rows
            && currentCol >= 0
            && currentCol < cols;
        }

        static char[,] Move(char[,] matrix, int currentRow, int currentCol)
        {
            char[,] tempMatrix = new char[matrix.GetLength(0), matrix.GetLength(1)];
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    tempMatrix[row, col] = matrix[row, col];
                    if (row == currentRow && col == currentCol)
                    {
                        if (tempMatrix[row,col] == '-')
                        {
                            tempMatrix[row, col] = '.';
                        }
                        else if (tempMatrix[row,col] == 'P')
                        {
                            tempMatrix[row, col] = 'R';
                        }
                        else if (tempMatrix[row,col] == 'A')
                        {
                            tempMatrix[row,col] = 'P';
                        }
                    }
                }
            }
            return tempMatrix;
        }
    }
}

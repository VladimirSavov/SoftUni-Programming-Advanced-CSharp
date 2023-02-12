using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace SoftUni
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] sizeOfMatrix = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[,] matrix = new int[sizeOfMatrix[0], sizeOfMatrix[1]];
            int[,] maxMatrix = new int[3, 3];
            int sum = 0;
            int maxValue = int.MinValue;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] ints = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = ints[col];
                }
            }
            for (int row = 0; row < matrix.GetLength(0) - 2; row++)
            {
                sum += matrix[row, row] + matrix[row, row + 1] + matrix[row, row + 2] + matrix[row + 1, row] + matrix[row + 1, row + 1] + matrix[row + 1, row + 2] + matrix[row + 2, row] + matrix[row + 2, row + 1] + matrix[row + 2, row + 2];
                
                if(sum > maxValue)
                {
                    maxValue = sum;
                    maxMatrix[0, 0] = matrix[row, row];
                    maxMatrix[0, 1] = matrix[row, row + 1];
                    maxMatrix[0, 2] = matrix[row, row + 2];
                    maxMatrix[1, 0] = matrix[row + 1, row];
                    maxMatrix[1, 1] = matrix[row + 1, row + 1];
                    maxMatrix[1, 2] = matrix[row + 1, row + 2];
                    maxMatrix[2, 0] = matrix[row + 2, row];
                    maxMatrix[2, 1] = matrix[row + 2, row + 1];
                    maxMatrix[2, 2] = matrix[row + 2, row + 2];
                }
                sum = 0;
            }
            Console.WriteLine("Sum = " + maxValue);
            for (int i = 0; i < maxMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < maxMatrix.GetLength(1); j++)
                {
                    Console.Write(maxMatrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}

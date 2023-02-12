using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace SoftUni
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sizeOfMatrix = int.Parse(Console.ReadLine());
            int[,] matrix = new int[sizeOfMatrix, sizeOfMatrix];
            int primaryDiagonal = 0;
            int secondaryDiagonal = 0;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] ints = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = ints[col];
                }
            }
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                primaryDiagonal += matrix[row, row];
            }
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                secondaryDiagonal += matrix[row, matrix.GetLength(0) - row - 1];
            }
            if(primaryDiagonal > secondaryDiagonal)
            {
                Console.WriteLine(primaryDiagonal - secondaryDiagonal);
            }
            else
            {
                Console.WriteLine(secondaryDiagonal - primaryDiagonal);
            }
        }
    }
}

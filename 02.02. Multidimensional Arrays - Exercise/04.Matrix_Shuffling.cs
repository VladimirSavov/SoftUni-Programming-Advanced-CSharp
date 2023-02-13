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
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string[] input = Console.ReadLine().Split().ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = int.Parse(input[col]);
                }
            }
            string[] command = Console.ReadLine().Split().ToArray();
            int changeMatrix = 0;
            while (command[0] != "END")
            {
                if (command[0] != "swap" || int.Parse(command[1]) > matrix.GetLength(0) || int.Parse(command[2]) > matrix.GetLength(1) || int.Parse(command[3]) > matrix.GetLength(0) || int.Parse(command[4]) > matrix.GetLength(1))
                {
                    Console.WriteLine("Invalid input!");
                }
                else
                {
                    changeMatrix = matrix[int.Parse(command[1]), int.Parse(command[2])]; 
                    matrix[int.Parse(command[1]), int.Parse(command[2])] = matrix[int.Parse(command[3]), int.Parse(command[4])];
                    matrix[int.Parse(command[3]), int.Parse(command[4])] = changeMatrix;
                    for (int i = 0; i < matrix.GetLength(0); i++)
                    {
                        for (int h = 0; h < matrix.GetLength(1); h++)
                        {
                            Console.Write(matrix[i, h] + " ");
                        }
                        Console.WriteLine();
                    }
                }
                command = Console.ReadLine().Split().ToArray();
            }
        }
    }
}

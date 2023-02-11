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
            int[] size = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            int[,] ints = new int[size[0], size[1]];
            for (int i = 0; i < ints.GetLength(0); i++)
            {
               int[] numsOfRow = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
                for (int j = 0; j < ints.GetLength(1); j++)
                {
                    ints[i, j] = numsOfRow[j];
                }
            }
            int maxValue = int.MinValue;
            int sum = 0;
            int[,] biggestMatrix = new int[2, 2];
            for (int i = 0; i < ints.GetLength(0) - 1; i++)
            {
                for (int j = 0; j < ints.GetLength(1) - 1; j++)
                {
                     sum += ints[i, j] + ints[i, j + 1] + ints[i + 1, j] + ints[i + 1, j + 1];
                    if(sum > maxValue)
                    {
                        biggestMatrix[0, 0] = ints[i, j];
                        biggestMatrix[0, 1] = ints[i, j + 1];
                        biggestMatrix[1, 0] = ints[i + 1, j];
                        biggestMatrix[1, 1] = ints[i + 1, j + 1];
                        maxValue = sum;
                    }
                    sum = 0;
                }
            }
            Console.WriteLine($"{biggestMatrix[0, 0]} {biggestMatrix[0, 1]}");
            Console.WriteLine($"{biggestMatrix[1, 0]} {biggestMatrix[1, 1]}");
            Console.WriteLine(maxValue);
        }
    }
}

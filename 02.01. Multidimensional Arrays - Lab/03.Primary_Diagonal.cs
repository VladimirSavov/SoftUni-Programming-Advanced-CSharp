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
            int size = int.Parse(Console.ReadLine());
            int[,] ints = new int[size, size];
            for (int i = 0; i < ints.GetLength(0); i++)
            {
               int[] numsOfRow = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
                for (int j = 0; j < ints.GetLength(1); j++)
                {
                    ints[i, j] = numsOfRow[j];
                }
            }
            int sum = 0;
            for (int i = 0; i < ints.GetLength(0); i++)
            {
                sum += ints[i, i];
            }
            Console.WriteLine(sum);
        }
    }
}

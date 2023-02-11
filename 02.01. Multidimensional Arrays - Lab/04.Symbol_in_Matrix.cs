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
               string row = Console.ReadLine();
                for (int j = 0; j < ints.GetLength(1); j++)
                {
                    ints[i, j] = row[j];
                }
            }
            char c = char.Parse(Console.ReadLine());
            for (int i = 0; i < ints.GetLength(0); i++)
            {
                for (int j = 0; j < ints.GetLength(1); j++)
                {
                    if(ints[i, j] == c)
                    {
                        Console.WriteLine($"({i}, {j})");
                        return;
                    }
                }
            }
            Console.WriteLine($"{c} does not occur in the matrix");
        }
    }
}

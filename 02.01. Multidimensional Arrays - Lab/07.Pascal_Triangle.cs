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
            int n = int.Parse(Console.ReadLine());
            ulong[][] array = new ulong[n][];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = new ulong[i + 1];
                for (int j = 0; j < array[i].Length; j++)
                {
                    if(j == 0)
                    {
                        array[i][j] = 1;
                    }
                    else if(j + 1 == array[i].Length || i == 1)
                    {
                        array[i][j] = 1;
                    }
                    else
                    {
                        array[i][j] = array[i - 1][j - 1] + array[i - 1][j];
                    }
                    Console.Write(array[i][j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}

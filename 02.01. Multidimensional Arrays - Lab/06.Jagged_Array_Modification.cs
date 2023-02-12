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
            int[][] arr = new int[n][];
            for (int i = 0; i < arr.Length; i++)
            {
                int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();    
                arr[i] = new int[input.Length];
                for (int j = 0; j < input.Length; j++)
                {
                    arr[i][j] = input[j];
                }
            }
            string[] command = Console.ReadLine().Split(' ').ToArray();
            while (command[0] != "END")
            {
                if(command[0] == "Add")
                {
                    if(int.Parse(command[1]) <= n - 1 && int.Parse(command[1]) >= 0 && int.Parse(command[2]) <= n - 1 && int.Parse(command[2]) >= 0)
                    {
                        arr[int.Parse(command[1])][int.Parse(command[2])] += int.Parse(command[3]);
                    }
                    else
                    {
                        Console.WriteLine("Invalid coordinates");
                    }
                }
                else if (command[0] == "Subtract")
                {
                    if (int.Parse(command[1]) <= n - 1 && int.Parse(command[1]) >= 0 && int.Parse(command[2]) <= n - 1 && int.Parse(command[2]) >= 0)
                    {
                        arr[int.Parse(command[1])][int.Parse(command[2])] -= int.Parse(command[3]);
                    }
                    else
                    {
                        Console.WriteLine("Invalid coordinates");
                    }
                }
                command = Console.ReadLine().Split(' ').ToArray();
            }
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    Console.Write(arr[i][j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}

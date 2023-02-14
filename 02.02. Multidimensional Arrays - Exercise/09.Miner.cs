using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
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
            int sizeOfMatrix = int.Parse(Console.ReadLine());
            string[] command = Console.ReadLine().Split().ToArray();
            string[,] matrix = new string[sizeOfMatrix, sizeOfMatrix];
            int[] currPosition = new int[2];
            int totalCoals = 0;
            int collectedCoals = 0;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string[] input = Console.ReadLine().Split().ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (input[col] == "s")
                    {
                        currPosition[0] = row;
                        currPosition[1] = col;
                    }
                    if(input[col] == "c")
                    {
                        totalCoals++;
                    }
                    matrix[row, col] = input[col];
                }
            }
            for (int i = 0; i < command.Length; i++)
            {
                if (command[i] == "up")
                {
                    currPosition[0] -= 1;
                    if(currPosition[0] < 0)
                    {
                        currPosition[0]++;
                        continue;
                    }
                    if (matrix[currPosition[0], currPosition[1]] == "e")
                    {
                        Console.WriteLine($"Game over! ({currPosition[0]}, {currPosition[1]})");
                        return;
                    }
                    else if(matrix[currPosition[0], currPosition[1]] == "c")
                    {
                        collectedCoals++;
                        matrix[currPosition[0], currPosition[1]] = "*";
                        if(collectedCoals == totalCoals)
                        {
                            Console.WriteLine($"You collected all coals! ({currPosition[0]}, {currPosition[1]})");
                            return;
                        }
                    }
                    else if (matrix[currPosition[0], currPosition[1]] == "*")
                    {
                        continue;
                    }
                }
                else if(command[i] == "right")
                {
                    currPosition[1] += 1;
                    if (currPosition[1] >= matrix.GetLength(1))
                    {
                        currPosition[1]--;
                        continue;
                    }
                    if (matrix[currPosition[0], currPosition[1]] == "e")
                    {
                        Console.WriteLine($"Game over! ({currPosition[0]}, {currPosition[1]})");
                        return;
                    }
                    else if (matrix[currPosition[0], currPosition[1]] == "c")
                    {
                        collectedCoals++;
                        matrix[currPosition[0], currPosition[1]] = "*";
                        if (collectedCoals == totalCoals)
                        {
                            Console.WriteLine($"You collected all coals! ({currPosition[0]}, {currPosition[1]})");
                            return;
                        }
                    }
                    else if (matrix[currPosition[0], currPosition[1]] == "*")
                    {
                        continue;
                    }
                }
                else if(command[i] == "left")
                {
                    currPosition[1] -= 1;
                    if (currPosition[1] < 0)
                    {
                        currPosition[1]++;
                        continue;
                    }
                    if (matrix[currPosition[0], currPosition[1]] == "e")
                    {
                        Console.WriteLine($"Game over! ({currPosition[0]}, {currPosition[1]})");
                        return;
                    }
                    else if (matrix[currPosition[0], currPosition[1]] == "c")
                    {
                        collectedCoals++;
                        matrix[currPosition[0], currPosition[1]] = "*";
                        if (collectedCoals == totalCoals)
                        {
                            Console.WriteLine($"You collected all coals! ({currPosition[0]}, {currPosition[1]})");
                            return;
                        }
                    }
                    else if (matrix[currPosition[0], currPosition[1]] == "*")
                    {
                        continue;
                    }
                }
                else if(command[i] == "down")
                {
                    currPosition[0] += 1;
                    if (currPosition[0] >= matrix.GetLength(0))
                    {
                        currPosition[0]--;
                        continue;
                    }
                    if (matrix[currPosition[0], currPosition[1]] == "e")
                    {
                        Console.WriteLine($"Game over! ({currPosition[0]}, {currPosition[1]})");
                        return;
                    }
                    else if (matrix[currPosition[0], currPosition[1]] == "c")
                    {
                        collectedCoals++;
                        matrix[currPosition[0], currPosition[1]] = "*";
                        if (collectedCoals == totalCoals)
                        {
                            Console.WriteLine($"You collected all coals! ({currPosition[0]}, {currPosition[1]})");
                            return;
                        }
                    }
                    else if (matrix[currPosition[0], currPosition[1]] == "*")
                    {
                        continue;
                    }
                }
            }
            Console.WriteLine($"{totalCoals - collectedCoals} coals left. ({currPosition[0]}, {currPosition[1]})");
        }
    }
}

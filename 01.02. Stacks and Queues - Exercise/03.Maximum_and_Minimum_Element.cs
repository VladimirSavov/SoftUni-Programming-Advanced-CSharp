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
            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < n; i++)
            {
                int[] command = Console.ReadLine().Split().Select(int.Parse).ToArray();
                if (command[0] == 1)
                {
                    stack.Push(command[1]);
                }
                else if(command[0] == 2)
                {
                    stack.Pop();
                }
                else if(command[0] == 3)
                {
                    if(stack.Count > 0)
                    {
                        Console.WriteLine(stack.Max());
                    }
                    else
                    {
                        Console.WriteLine();
                    }
                }
                else if(command[0] == 4)
                {
                    if(stack.Count > 0)
                    {
                        Console.WriteLine(stack.Min());
                    }
                    else
                    {
                        Console.WriteLine();
                    }
                }
            }
            Console.WriteLine(String.Join(", ", stack));
        }
    }
}

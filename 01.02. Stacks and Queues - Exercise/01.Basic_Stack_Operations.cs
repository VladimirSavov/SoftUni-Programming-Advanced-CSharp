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
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Stack<int> stack = new Stack<int>();
            int[] n = Console.ReadLine().Split().Select(int.Parse).ToArray();
            for (int i = 0; i < n.Length; i++)
            {
                stack.Push(n[i]);
            }
            for (int i = 0; i < input[1]; i++)
            {
                stack.Pop();
            }
            if (stack.Contains(input[2]))
            {
                Console.WriteLine("true");
            }
            else if(stack.Count > 0)
            {
                int minNum = int.MaxValue;
                foreach (var item in stack)
                {
                    if(item < minNum)
                    {
                        minNum = item;
                    }
                }
                Console.WriteLine(minNum);
            }
            else
            {
                Console.WriteLine(0);
            }
        }
    }
}

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
            int maxCapacity = int.Parse(Console.ReadLine());
            int racks = 0;
            int capacity = 0;
            Stack<int> stack = new Stack<int>();
            foreach (var item in input)
            {
                stack.Push(item);
            }
            foreach (var item in stack)
            {
                if(capacity + item <= maxCapacity)
                {
                    capacity += item;
                }
                else
                {
                    capacity = 0;
                    capacity += item;
                    racks++;
                }
            }
            if(capacity > 0)
            {
                racks++;
            }
            Console.WriteLine(racks);
        }
    }
}

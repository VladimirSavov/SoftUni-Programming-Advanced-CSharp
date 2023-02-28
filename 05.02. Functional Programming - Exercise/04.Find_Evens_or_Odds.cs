using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Tracing;
using System.Linq;

namespace SoftUni
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Predicate<int> pred = number => number % 2 == 0;
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            List<int> numbers = new List<int>();
            for (int i = nums[0]; i <= nums[1]; i++)
            {
                numbers.Add(i);
            }
            string command = Console.ReadLine();
            if(command == "even")
            {
                Console.WriteLine(string.Join(" ", numbers.Where(x => pred(x))));
            }
            else
            {
                Console.WriteLine(string.Join(" ", numbers.Where(x => !pred(x))));
            }
        }
    }
}

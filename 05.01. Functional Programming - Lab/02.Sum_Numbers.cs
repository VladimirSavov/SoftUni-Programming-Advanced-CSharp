using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace SoftUni
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            Console.WriteLine(input.Length);
            int sum = 0;
            foreach (var item in input)
            {
                sum += item;
            }
            Console.WriteLine(sum);
        }
    }
}

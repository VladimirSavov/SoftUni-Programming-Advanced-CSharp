using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.Tracing;
using System.Linq;

namespace SoftUni
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Func<int[], int> funtion = input =>
            {
                int minValue = int.MaxValue;
                foreach (var item in input)
                {
                    if (item < minValue)
                    {
                        minValue = item;
                    }
                }
                return minValue;
            };

            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Console.WriteLine(funtion(input));
        }
    }
}

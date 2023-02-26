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
            var output = input.Where(x => x % 2 == 0).OrderBy(x => x).ToArray();
            Console.WriteLine(string.Join(", ", output));
        }
    }
}

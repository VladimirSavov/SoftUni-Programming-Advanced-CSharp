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
            var intput = Console.ReadLine().Split(", ").Select(double.Parse).Select(x => x * 1.2).ToArray();
            foreach (var item in intput)
            {
                Console.WriteLine($"{item:F2}");
            } 
        }
    }
}

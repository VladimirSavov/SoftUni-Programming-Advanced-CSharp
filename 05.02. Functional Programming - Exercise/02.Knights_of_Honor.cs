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
            Action<List<string>> printCollection = input
                => Console.WriteLine("Sir " + string.Join(Environment.NewLine + "Sir ", input));

            List<string> input = Console.ReadLine().Split(' ').ToList();

            printCollection(input);            
        }
    }
}

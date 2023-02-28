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
            Action<string[]> printCollection = input
                => Console.WriteLine(string.Join(Environment.NewLine, input));

            string[] input = Console.ReadLine().Split(' ');

            printCollection(input);            
        }
    }
}

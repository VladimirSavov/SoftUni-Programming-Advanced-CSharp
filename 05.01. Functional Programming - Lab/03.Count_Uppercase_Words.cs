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
            string[] input = Console.ReadLine().Split().ToArray();
            Func<string, bool> func = word => char.IsUpper(word[0]);
            var output = input.Where(func);
            foreach (var item in output)
            {
                Console.WriteLine(item);
            }
        }
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Xml;

namespace SoftUni
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Func<string, int, bool> func = (input, n) => input.Length <= n;
            var result = Console.ReadLine().Split().Where(x => func(x, n)).ToArray();
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }
    }
}

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
            Func<List<int>, int, List<int>> reverseAndExclude = (input, command) =>
            {
                var list = new List<int>();
                input.Reverse();
                foreach (int number in input)
                {
                    double result = (double)number / command;
                    string word = result.ToString();
                    if (word.Contains('.'))
                    {
                        list.Add(number);
                    }
                }
                Console.WriteLine(string.Join(" ", list));
                return list;    
            };
            List<int> input = Console.ReadLine().Split().Select(int.Parse).ToList();
            int command = int.Parse(Console.ReadLine());
            reverseAndExclude(input, command);
        }
    }
}

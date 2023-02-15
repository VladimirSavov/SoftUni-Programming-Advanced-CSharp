using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace SoftUni
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, List<double>> dic = new Dictionary<string, List<double>>();
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split().ToArray();
                if (dic.ContainsKey(input[0]))
                {
                    dic[input[0]].Add(double.Parse(input[1]));
                }
                else
                {
                    dic[input[0]] = new List<double>() { double.Parse(input[1])};
                }
            }
            foreach(var i in dic)
            {
                double sum = 0;
                double average = 0;
                for (int k = 0; k < i.Value.Count; k++)
                {
                    sum += i.Value[k];
                }
                average = sum / i.Value.Count;
                Console.Write($"{i.Key} -> ");
                for (int h = 0; h < i.Value.Count; h++)
                {
                    Console.Write($"{i.Value[h]:F2} ");
                }
                Console.Write($"(avg: {average:F2})");
                Console.WriteLine();
            }
        }
    }
}

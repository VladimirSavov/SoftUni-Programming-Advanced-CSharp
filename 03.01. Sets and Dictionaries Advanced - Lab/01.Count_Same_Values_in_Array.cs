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
            Dictionary<double, int> dic = new Dictionary<double, int>();
            double[] input = Console.ReadLine().Split().Select(double.Parse).ToArray();
            for (int i = 0; i < input.Length; i++)
            {
                if (dic.ContainsKey(input[i]))
                {
                    dic[input[i]]++;
                }
                else
                {
                    dic.Add(input[i], 1);
                }
            }
            foreach(var i in dic)
            {
                Console.WriteLine($"{i.Key} - {i.Value} times");
            }
        }
    }
}

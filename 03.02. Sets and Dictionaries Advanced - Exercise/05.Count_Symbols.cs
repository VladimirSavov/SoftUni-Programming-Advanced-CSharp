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
            string input = Console.ReadLine();
            Dictionary<char, int> output = new Dictionary<char, int>();
            for (int i = 0; i < input.Length; i++)
            {
                if (output.ContainsKey(input[i]))
                {
                    output[input[i]]++;
                }
                else
                {
                    output.Add(input[i], 1);
                }
            }
            var newOutput = output.OrderBy(c => c.Key);
            foreach (var item in newOutput)
            {
                Console.WriteLine($"{item.Key}: {item.Value} time/s");
            }
        }
    }
}

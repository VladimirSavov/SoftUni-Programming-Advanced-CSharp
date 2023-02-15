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
            Dictionary<string, Dictionary<string, double>> dic = new Dictionary<string, Dictionary<string, double>>();
            string[] command = Console.ReadLine().Split(", ").ToArray();
            while (command[0] != "Revision")
            {
                if (dic.ContainsKey(command[0]))
                {
                    dic[command[0]].Add(command[1], double.Parse(command[2]));
                }
                else
                {
                    dic[command[0]] = new Dictionary<string, double>();
                    dic[command[0]].Add(command[1], double.Parse(command[2]));
                }
                command = Console.ReadLine().Split(", ").ToArray();
            }
            var sorted = dic.OrderBy(x => x.Key);
            foreach (var market in sorted)
            {
                Console.WriteLine(market.Key + "->");
                foreach (var product in market.Value)
                {
                    Console.WriteLine($"Product: {product.Key}, Price: {product.Value}");
                }
            }
        }
    }
}

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
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, Dictionary<string, List<string>>> dic = new Dictionary<string, Dictionary<string, List<string>>>();
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(' ');
                if (dic.ContainsKey(input[0]))
                {
                    if (dic[input[0]].ContainsKey(input[1]))
                    {
                        dic[input[0]][input[1]].Add(input[2]);
                    }
                    else
                    {
                        dic[input[0]].Add(input[1], new List<string>() {input[2]});
                    }
                }
                else if (!dic.ContainsKey(input[0]))
                {
                    dic[input[0]] = new Dictionary<string, List<string>>();
                    dic[input[0]].Add(input[1], new List<string>());
                    if (dic[input[0]].ContainsKey(input[1]))
                    {
                        dic[input[0]][input[1]].Add(input[2]);
                    }
                    else
                    {
                        dic[input[0]].Add(input[1], new List<string>() { input[2] });
                    }
                }
            }
            foreach (var continent in dic)
            {
                Console.WriteLine($"{continent.Key}:");
                foreach (var country in continent.Value)
                {
                    Console.WriteLine($"   {country.Key} -> {string.Join(", ", country.Value)}");
                }
            }
        }
    }
}

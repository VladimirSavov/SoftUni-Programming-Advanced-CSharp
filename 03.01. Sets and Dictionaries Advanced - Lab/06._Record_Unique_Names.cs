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
            HashSet<string> set = new HashSet<string>();
            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                if (!set.Contains(name))
                {
                    set.Add(name);
                }
            }
            foreach (var item in set)
            {
                Console.WriteLine(item);
            }
        }
    }
}

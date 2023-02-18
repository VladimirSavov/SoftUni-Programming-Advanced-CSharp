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
                string[] word = Console.ReadLine().Split(' ').ToArray();
                for (int h = 0; h < word.Length; h++)
                {
                    set.Add(word[h]);
                }
            }
            var newSet = set.OrderByDescending(x => x).ToList();
            newSet.Reverse();
            foreach (var item in newSet)
            {
                Console.Write(item + " ");
            }
        }
    }
}

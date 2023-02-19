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
            int[] arr = new int[n];
            HashSet<int> set = new HashSet<int>();  
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
                if (set.Contains(arr[i]))
                {
                    set.Remove(arr[i]);
                }
                else
                {
                    set.Add(arr[i]);
                }
            }
            foreach (var item in arr)
            {
                if (!set.Contains(item))
                {
                    Console.WriteLine(item);
                    return;
                }
            }
        }
    }
}

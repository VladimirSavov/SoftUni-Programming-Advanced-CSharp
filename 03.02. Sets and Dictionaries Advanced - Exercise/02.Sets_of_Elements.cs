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
            int[] n = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] n1 = new int[n[0]];
            int[] n2 = new int[n[1]];
            HashSet<int> output = new HashSet<int>(); 
            for (int i = 0; i < n[0]; i++)
            {
                n1[i] = int.Parse(Console.ReadLine());
            }
            for (int j = 0; j < n[1]; j++)
            {
                n2[j] = int.Parse(Console.ReadLine());
            }
            if(n1.Length >= n2.Length)
            {
                for (int i = 0; i < n1.Length; i++)
                {
                    for (int  h= 0; h < n2.Length; h++)
                    {
                        if(n1[i] == n2[h])
                        {
                            output.Add(n1[i]);
                        }
                    }
                }
            }
            else
            {
                for (int i = 0; i < n2.Length; i++)
                {
                    for (int h = 0; h < n1.Length; h++)
                    {
                        if (n2[i] == n1[h])
                        {
                            output.Add(n2[i]);
                        }
                    }
                }
            }
            foreach (var item in output)
            {
                Console.Write(item + " ");
            }
        }
    }
}

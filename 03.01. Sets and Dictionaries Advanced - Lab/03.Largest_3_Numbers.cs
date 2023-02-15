using System;
using System.Collections;
using System.Data;
using System.Linq;

namespace SoftUni
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] sorted = input.OrderByDescending(x => x).ToArray();
            for (int i = 0; i < sorted.Length; i++)
            {
                if(i < 3)
                {
                    Console.Write(sorted[i] + " ");
                }
            }
        }
    }
}

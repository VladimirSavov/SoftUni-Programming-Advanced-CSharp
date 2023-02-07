using System;
using System.Collections;
using System.Collections.Generic;
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
            int minNum = int.MaxValue;
            for (int i = 0; i < n; i++)
            {
                int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
                if (input[0] < input[1])
                {
                    int result = input[1] - input[0];
                    if(result < minNum)
                    {
                        minNum = result;
                    }
                }
            }
            Console.WriteLine(minNum);
        }
    }
}

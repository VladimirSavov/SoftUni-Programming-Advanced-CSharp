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
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Queue<int> queue = new Queue<int>();
            int[] n = Console.ReadLine().Split().Select(int.Parse).ToArray();
            for (int i = 0; i < n.Length; i++)
            {
                queue.Enqueue(n[i]);
            }
            for (int i = 0; i < input[1]; i++)
            {
                queue.Dequeue();
            }
            if (queue.Contains(input[2]))
            {
                Console.WriteLine("true");
            }
            else if(queue.Count > 0)
            {
                int minNum = int.MaxValue;
                foreach (var item in queue)
                {
                    if(item < minNum)
                    {
                        minNum = item;
                    }
                }
                Console.WriteLine(minNum);
            }
            else
            {
                Console.WriteLine(0);
            }
        }
    }
}

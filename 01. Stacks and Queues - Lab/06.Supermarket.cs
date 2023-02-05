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
            string input = Console.ReadLine();
            Queue<string> queue = new Queue<string>();
            while (true)
            {
                if(input == "Paid")
                {
                    foreach (var item in queue)
                    {
                        Console.WriteLine(item);
                    }
                    queue.Clear();
                    input = Console.ReadLine();
                    continue;
                }
                if(input == "End")
                {
                    Console.WriteLine($"{queue.Count} people remaining.");
                    queue.Clear();
                    break;
                }
                queue.Enqueue(input);
                input = Console.ReadLine();
            }
        }
    }
}

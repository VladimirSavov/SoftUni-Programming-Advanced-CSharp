using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Xml;

namespace SoftUni
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Func<int, int[], List<int>> listOfPredicates = (number, dividers) =>
            {
                List<int> list = new List<int>();
                for (int i = 1; i <= number; i++)
                {                
                    bool isTrue = true;
                    foreach (var item in dividers)
                    {
                        if(i % item != 0)
                        {
                            isTrue = false;  
                        }
                    }
                    if (isTrue)
                    {
                        list.Add(i);
                    }
                }
                return list;
            };
            int number = int.Parse(Console.ReadLine());
            int[] dividers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var result = listOfPredicates(number, dividers);
            Console.WriteLine(string.Join(" ", result));
        }
    }
}

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
            int quantityOfTheFood = int.Parse(Console.ReadLine());
            int[] ints = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int biggestOrder = 0;
            int orderLeft = 0;
            Queue<int> queue = new Queue<int>();
            foreach (int i in ints)
            {
                queue.Enqueue(i);
            }
            foreach (var order in queue)
            {
                if(quantityOfTheFood - order >= 0)
                {
                    quantityOfTheFood -= order;
                }
                else
                {
                    orderLeft += order;
                }
                if(order > biggestOrder)
                {
                    biggestOrder = order;
                }
            }
            Console.WriteLine(biggestOrder);
            if(orderLeft == 0)
            {
                Console.WriteLine("Orders complete");
            }
            else
            {
                Console.WriteLine($"Orders left: {orderLeft}");
            }
        }
    }
}

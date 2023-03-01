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
            Func<int[], int[]> add = number =>
            {
                int[] output = new int[number.Length];
                for (int i = 0; i < number.Length; i++)
                {
                    output[i] = number[i] + 1;
                }
                for (int i = 0; i < number.Length; i++)
                {
                    number[i] = output[i];
                }
                return output;
            };
            Func<int[], int[]> multiply = number =>
            {
                int[] output = new int[number.Length];
                for (int i = 0; i < number.Length; i++)
                {
                    output[i] = number[i] * 2;
                }
                for (int i = 0; i < number.Length; i++)
                {
                    number[i] = output[i];
                }
                return output;
            };
            Func<int[], int[]> subtract = number =>
            {
                int[] output = new int[number.Length];
                for (int i = 0; i < number.Length; i++)
                {
                    output[i] = number[i] - 1;
                }
                for (int i = 0; i < number.Length; i++)
                {
                    number[i] = output[i];
                }
                return output;
            };
            Action<int[]> print = number => 
            Console.WriteLine(string.Join(" ", number));
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string command = Console.ReadLine();
            while (command != "end")
            {
                if(command == "add")
                {
                    add(input);
                }
                else if(command == "multiply")
                {
                    multiply(input);
                }
                else if(command == "subtract")
                {
                    subtract(input);
                }
                else if(command == "print")
                {
                    print(input);
                }
                command = Console.ReadLine();
            }
        }
    }
}

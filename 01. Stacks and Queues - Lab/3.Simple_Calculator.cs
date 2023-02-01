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
            string[] input = Console.ReadLine().Split().ToArray();
            Array.Reverse(input);
            Stack<int> stack = new Stack<int>();
            List<char> c = new List<char>();
            int result = 0;
            for (int i = 1; i < input.Length; i+=2)
            {
                c.Add(char.Parse(input[i]));
            }
            for (int i = 0; i < input.Length; i+=2)
            {
                stack.Push(int.Parse(input[i]));
            }
            c.Reverse();
            int k = stack.Count;
            for (int i = 0; i < k; i++)
            {
                int num1 = stack.Pop();
                if (i == 0)
                {
                    int num2 = stack.Pop();
                    if (c[i] == '-')
                    {
                        result = num1 - num2;
                    }
                    else if(c[i] == '+')
                    {
                        result = num1 + num2;
                    }     
                }
                else
                {
                    if (c[i] == '-')
                    {
                        result =  result - num1;
                    }
                    else if (c[i] == '+')
                    {
                        result = result + num1;
                    }
                }
                if(stack.Count > 0)
                {
                    k++;
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine(result);
        }
    }
}

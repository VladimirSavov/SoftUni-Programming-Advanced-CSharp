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
            Stack<int> stack = new Stack<int>();
            for (int i = 0; i < input.Length; i++)
            {
                char c = input[i];
                if(c != ' ')
                {
                    stack.Push(int.Parse(input[i].ToString()));
                }
            }
            string[] command = Console.ReadLine().Split().ToArray();
            string firstCommand = command[0].ToLower();
            while (firstCommand != "end")
            {
                if(firstCommand == "add")
                {
                    for (int i = 1; i < command.Length; i++)
                    {
                        stack.Push(int.Parse(command[i]));
                    }
                }
                else if(firstCommand == "remove" && stack.Count > int.Parse(command[1]))
                {
                    for (int i = 0; i < int.Parse(command[1]); i++)
                    {
                        stack.Pop();
                    }
                }
                command = Console.ReadLine().Split().ToArray();
                firstCommand = command[0].ToLower();
            }
            int sum = 0;
            foreach (var item in stack)
            {
                sum += item;
            }
            Console.WriteLine($"Sum: {sum}");
        }
    }
}

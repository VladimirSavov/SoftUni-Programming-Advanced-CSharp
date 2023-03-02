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
            Func<string, string, bool> StartWith = (input, criter) =>
            {
                int n = input.IndexOf(criter);
                if (n == 0)
                {
                    return true;
                }
                return false;
            };
            Func<string, string, bool> EndWith = (input, criter) =>
            {
                int n = input.IndexOf(criter);
                if (n == input.Length - criter.Length)
                {
                    return true;
                }
                return false;
            };
            Func<string, int, bool> length = (input, length) => input.Length == length;
            List<string> input = Console.ReadLine().Split().ToList();
            string[] command = Console.ReadLine().Split().ToArray();
            while (command[0] != "Party!")
            {
                if (command[0] == "Remove")
                {
                    if (command[1] == "StartsWith")
                    {
                        int n = input.Count;
                        for (int i = 0; i < n; i++)
                        {
                            if (StartWith(input[i], command[2]))
                            {
                                input.Remove(input[i]);
                                n--;
                            }
                        }
                    }
                    else if (command[1] == "EndsWith")
                    {
                        int n = input.Count;
                        for (int i = 0; i < n; i++)
                        {
                            if (EndWith(input[i], command[2]))
                            {
                                input.Remove(input[i]);
                                n--;
                            }
                        }
                    }
                    else if (command[1] == "Length")
                    {
                        int n = input.Count;
                        for (int i = 0; i < n; i++)
                        {
                            if (length(input[i], int.Parse(command[2])))
                            {
                                input.Remove(input[i]);
                                n--;
                            }
                        }
                    }
                }
                else if (command[0] == "Double")
                {
                    if (command[1] == "StartsWith")
                    {
                        int n = input.Count;
                        for (int i = 0; i < n; i++)
                        {
                            if (StartWith(input[i], command[2]))
                            {
                                input.Insert(i + 1, input[i]);
                            }
                        }
                    }
                    else if (command[1] == "EndsWith")
                    {
                        int n = input.Count;
                        for (int i = 0; i < n; i++)
                        {
                            if (EndWith(input[i], command[2]))
                            {
                                input.Insert(i + 1, input[i]);
                            }
                        }
                    }
                    else if (command[1] == "Length")
                    {
                        int n = input.Count;
                        for (int i = 0; i < n; i++)
                        {
                            if (length(input[i], int.Parse(command[2])))
                            {
                                input.Insert(i + 1, input[i]);
                                i++;
                            }
                        }
                    }
                }
                command = Console.ReadLine().Split().ToArray();
            }
            if (input.Count != 0)
            {
                Console.WriteLine(string.Join(", ", input) + " are going to the party!");
            }
            else
            {
                Console.WriteLine("Nobody is going to the party!");
            }
        }
    }
}

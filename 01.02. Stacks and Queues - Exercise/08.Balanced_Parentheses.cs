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
            bool isTrue = true;
            int c = 1;
            for (int i = 0; i < input.Length / 2; i++)
            {
                char c1 = input[i];
                char c2 = input[input.Length - c];
                if(c1 == '(')
                {
                    if(c2 != ')')
                    {
                        isTrue = false;
                    }
                }
                else if(c1 == '[')
                {
                    if(c2 != ']')
                    {
                        isTrue = false;
                    }
                }
                else if(c1 == '{')
                {
                    if(c2 != '}')
                    {
                        isTrue = false;
                    }
                }
                c++;
            }
            if (isTrue)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}

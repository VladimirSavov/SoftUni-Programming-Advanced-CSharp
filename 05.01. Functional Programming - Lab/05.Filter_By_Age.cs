using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.Tracing;
using System.Linq;

namespace SoftUni
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, int> input = new Dictionary<string, int>();
            for (int i = 0; i < n; i++)
            {
                string[] inputData = Console.ReadLine().Split(", ").ToArray();
                input[inputData[0].ToString()] = int.Parse(inputData[1].ToString());
            }
            string condition = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            string[] inputCondition = Console.ReadLine().Split().ToArray();

            List<string> outputName = new List<string>();
            List<int> outputAge = new List<int>();
            var output = Method(input, condition, age);
            if (inputCondition[0] == "name" && inputCondition.Length < 2)
            {
                foreach (var item in output)
                {
                    outputName.Add(item.Key);
                }
                foreach (var item in outputName)
                {
                    Console.WriteLine(item);
                }
                return;
            }
            else if (inputCondition[0] == "age" && inputCondition.Length < 2)
            {
                foreach (var item in output)
                {
                    outputAge.Add(item.Value);
                }
                foreach (var item in outputAge)
                {
                    Console.WriteLine(item);
                }
                return;
            }
            else
            {
                foreach (var item in output)
                {
                    Console.WriteLine($"{item.Key} - {item.Value}");
                }
            }
        }
        static Dictionary<string, int> Method(Dictionary<string, int> input, string condition, int age)
        {
            Dictionary<string, int> output = new Dictionary<string, int>();
            if (condition == "older")
            {
                foreach (var item in input)
                {
                    if(item.Value >= age)
                    {
                        output[item.Key] = item.Value;
                    }
                }
            }   
            else if (condition == "younger")
            {
                foreach (var item in input)
                {
                    if (item.Value < age)
                    {
                        output[item.Key] = item.Value;
                    }
                }
            }
            return output;  
        }
    }
}

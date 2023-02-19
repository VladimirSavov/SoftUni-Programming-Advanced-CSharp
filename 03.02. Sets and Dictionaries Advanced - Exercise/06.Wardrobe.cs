using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace SoftUni
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, List<string>> clothes = new Dictionary<string, List<string>>();
            for (int i = 0; i < n; i++)
            {
                string[] inputClothes = Console.ReadLine().Split(" -> ").ToArray();
                string[] inputDress = inputClothes[1].Split(",").ToArray();
                if (clothes.ContainsKey(inputClothes[0]))
                {
                    for (int h = 0; h < inputDress.Length; h++)
                    {
                        clothes[inputClothes[0]].Add(inputDress[h]);
                    }
                }
                else
                {
                    clothes[inputClothes[0]] = new List<string>();
                    for (int h = 0; h < inputDress.Length; h++)
                    {
                        clothes[inputClothes[0]].Add(inputDress[h]);
                    }
                }
            }
            string[] soughtAfterGarment = Console.ReadLine().Split(' ').ToArray();
            foreach (var color in clothes)
            {
                Console.WriteLine($"{color.Key} clothes:");
                HashSet<string> list = new HashSet<string>();
                for (int i = 0; i < color.Value.Count; i++)
                {   
                    list.Add(color.Value[i]);
                    string word = color.Value[i];
                    int counter = 0;
                    for (int k = 0; k < color.Value.Count; k++)
                    {
                        if(color.Value[k] == word)
                        {
                            counter++;
                        }
                    }
                    Console.Write($"* {color.Value[i]} - {counter}");
                    if (color.Key == soughtAfterGarment[0] && color.Value[i] == soughtAfterGarment[1])
                    {
                        Console.Write($" (found!)");
                        Console.WriteLine();
                        continue;
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}

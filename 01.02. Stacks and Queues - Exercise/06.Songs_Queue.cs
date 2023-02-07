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
            string[] songs = Console.ReadLine().Split(", ").ToArray();
            Queue<string> queue = new Queue<string>();
            foreach (var song in songs)
            {
                queue.Enqueue(song);
            }
            while (queue.Count >= 0)
            {
                string[] command = Console.ReadLine().Split("Add ", ' ').ToArray();
                if (command[0] == "Play")
                {
                    if(queue.Count > 0)
                    {
                        queue.Dequeue();
                        continue;
                    }
                    if(queue.Count == 0)
                    {
                        Console.WriteLine("No more songs!");
                        break;
                    }
                }
                else if(command[0] == "Show")
                {
                    Console.WriteLine(string.Join(", ", queue));
                }
                else
                {
                    string word = "";
                    word += command[1];
                    if (queue.Contains(word))
                    {
                        Console.WriteLine($"{word} is already contained!");
                    }
                    else
                    {
                        queue.Enqueue(word);
                    }
                }
            }
        }
    }
}

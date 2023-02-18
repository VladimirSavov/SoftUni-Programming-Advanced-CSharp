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
            string command = Console.ReadLine();
            HashSet<string> peoples = new HashSet<string>();
            while (command != "PARTY")
            {
                peoples.Add(command);
                command = Console.ReadLine();
            }
            string command2 = Console.ReadLine();
            while (command2 != "END")
            {
                peoples.Remove(command2);
                command2 = Console.ReadLine();  
            }
            Console.WriteLine(peoples.Count);
            var sortedPeoples = peoples.OrderByDescending(x => x[0] == '1' || x[0] == '2' || x[0] == '3' || x[0] == '4' || x[0] == '5' || x[0] == '6' || x[0] == '7' || x[0] == '8' || x[0] == '9').ToList();
            foreach (var i in sortedPeoples)
            {
                Console.WriteLine(i);
            }    
        }
    }
}

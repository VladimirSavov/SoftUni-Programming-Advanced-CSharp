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
            string[] command = Console.ReadLine().Split(", ").ToArray();
            HashSet<string> parking = new HashSet<string>();
            while (command[0] != "END")
            {
                if(command[0] == "IN")
                {
                    parking.Add(command[1]);
                }
                else
                {
                    parking.Remove(command[1]);
                }
                command = Console.ReadLine().Split(", ").ToArray();
            }
            if(parking.Count == 0)
            {
                Console.WriteLine("Parking Lot is Empty");
            }
            else
            {
                foreach (var car in parking)
                {
                    Console.WriteLine(car);
                }
            }
        }
    }
}

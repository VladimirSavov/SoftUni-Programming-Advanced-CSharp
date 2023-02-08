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
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int greenLight = 0;
            int freeWindow = 0;
            int carsPassedTheRoad = 0;
            bool isCrash = false;
            string currCar = "";
            string command = Console.ReadLine();
            Queue<char> queue = new Queue<char>();
            while (command != "END")
            {
                greenLight = a;
                freeWindow = b;
                while (command != "green")
                {
                    for (int i = 0; i < command.Length; i++)
                    {
                        queue.Enqueue(command[i]);
                    }
                    command = Console.ReadLine();
                    if(command != "green")
                    {
                        currCar = command;
                    }
                    queue.Enqueue(' ');
                }
                for (int i = 0; i < queue.Count; i++)
                {
                    if(greenLight != 0)
                    {
                        if(queue.Peek() == ' ')
                        {
                            queue.Dequeue();
                            carsPassedTheRoad++;
                            continue;
                        } 
                        queue.Dequeue();
                        greenLight--;
                    }
                    else if(greenLight == 0 && freeWindow != 0)
                    {
                        if(queue.Peek() != ' ')
                        {
                            queue.Dequeue();
                            freeWindow--;
                        }
                        else
                        {
                            isCrash = true;
                            break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("A crash happened!");
                        Console.WriteLine($"{currCar} was hit at {queue.Peek()}.");
                        return;
                    }
                    i--;
                }
                if(isCrash != true)
                {
                    carsPassedTheRoad++;
                }
                command = Console.ReadLine();
            }
            Console.WriteLine("Everyone is safe.");
            Console.WriteLine($"{carsPassedTheRoad} total cars passed the crossroads.");
        }
    }
}

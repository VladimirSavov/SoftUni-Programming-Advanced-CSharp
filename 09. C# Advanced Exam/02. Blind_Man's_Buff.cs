using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorsAndComparators
{
    class StartUp
    {
        static void Main()
        {
            int[] n = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string[,] playground = new string[n[0], n[1]];
            int touchedPlayers = 0;
            int moveCount = 0;
            int[] currPosition = new int[2];

            for (int i = 0; i < playground.GetLength(0); i++)
            {
                string[] input = Console.ReadLine().Split().ToArray();
                for (int k = 0; k < playground.GetLength(1); k++)
                {
                    playground[i, k] = input[k];
                    if (input[k] == "B")
                    {
                        currPosition[0] = i;
                        currPosition[1] = k;
                    }
                }
            }
            string command = Console.ReadLine();
            while (command != "Finish" && touchedPlayers != 3)
            {
                if(command == "up")
                {
                    if (currPosition[0] - 1 < 0 || playground[currPosition[0] - 1, currPosition[1]] == "O")
                    {
                        command = Console.ReadLine();
                        continue;
                    }
                    else
                    {
                        if (playground[currPosition[0] - 1, currPosition[1]] == "P")
                        {
                            touchedPlayers++;
                            moveCount++;
                            playground[currPosition[0], currPosition[1] - 1] = "-";
                            currPosition[0] = currPosition[0] - 1;
                        }
                        else
                        {
                            moveCount++;
                            currPosition[0] = currPosition[0] - 1;
                        }
                    }
                }
                else if(command == "down")
                {
                    if (currPosition[0] + 1 > playground.GetLength(0) || playground[currPosition[0] + 1, currPosition[1]] == "O")
                    {
                        command = Console.ReadLine();
                        continue;
                    }
                    else
                    {
                        if (playground[currPosition[0] + 1, currPosition[1]] == "P")
                        {
                            touchedPlayers++;
                            moveCount++;
                            playground[currPosition[0], currPosition[1] - 1] = "-";
                            currPosition[0] = currPosition[0] + 1;
                        }
                        else
                        {
                            moveCount++;
                            currPosition[0] = currPosition[0] + 1;
                        }
                    }
                }
                else if(command == "right")
                {
                    if (currPosition[1] + 1 < playground.GetLength(1) || playground[currPosition[0], currPosition[1] + 1] == "O")
                    {
                        command = Console.ReadLine();
                        continue;
                    }
                    else
                    {
                        if (playground[currPosition[0], currPosition[1] + 1] == "P")
                        {
                            touchedPlayers++;
                            moveCount++;
                            playground[currPosition[0], currPosition[1] - 1] = "-";
                            currPosition[1] = currPosition[1] + 1;
                        }
                        else
                        {
                            moveCount++;
                            currPosition[1] = currPosition[1] + 1;
                        }
                    }
                }
                else if(command == "left")
                {
                    if (currPosition[1] - 1 < 0 || playground[currPosition[0], currPosition[1] - 1] == "O")
                    {
                        command = Console.ReadLine();
                        continue;
                    }
                    else
                    {
                        if (playground[currPosition[0], currPosition[1] - 1] == "P")
                        {
                            touchedPlayers++;
                            moveCount++;
                            playground[currPosition[0], currPosition[1] - 1] = "-";
                            currPosition[1] = currPosition[1] - 1;
                        }
                        else
                        {
                            moveCount++;
                            currPosition[1] = currPosition[1] - 1;
                        }
                    }
                }
                command = Console.ReadLine();
            }
            Console.WriteLine("Game over!");
            Console.WriteLine($"Touched opponents: {touchedPlayers} Moves made: {moveCount}");
        }
    }
}

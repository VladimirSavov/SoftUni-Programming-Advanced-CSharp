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
            var reverseTextiles = new Queue<int>(Console.ReadLine().Split().Select(int.Parse).ToArray());
            var reverseMedicaments = new Stack<int>(Console.ReadLine().Split().Select(int.Parse).ToArray());
            Stack<int> medicaments = new Stack<int>(reverseMedicaments.Reverse());
            var textiles = new Queue<int>(reverseTextiles);
            Dictionary<string, int> sorted = new Dictionary<string, int>();   

            while (textiles.Count > 0 && medicaments.Count > 0)
            {
                int remainingResourses = 0;
                var textile = textiles.Peek();
                var medicament = medicaments.Peek();
                int sum = textile + medicament;
                if(sum == 100)
                {
                    if (sorted.ContainsKey("MedKit"))
                    {
                        sorted["MedKit"]++;
                    }
                    else
                    {
                        sorted.Add("MedKit", 1);
                    }
                    textiles.Dequeue();
                    medicaments.Pop();
                }
                else if(sum == 40)
                {
                    if (sorted.ContainsKey("Bandage"))
                    {
                        sorted["Bandage"]++;
                    }
                    else
                    {
                        sorted.Add("Bandage", 1);
                    }
                    textiles.Dequeue();
                    medicaments.Pop();
                }
                else if(sum == 30)
                {
                    if (sorted.ContainsKey("Patch"))
                    {
                        sorted["Patch"]++;
                    }
                    else
                    {
                        sorted.Add("Patch", 1);
                    }
                    textiles.Dequeue();
                    medicaments.Pop();
                }
                else if(sum > 100)
                {
                    if (sorted.ContainsKey("MedKit"))
                    {
                        sorted["MedKit"]++;
                    }
                    else
                    {
                        sorted.Add("MedKit", 1);
                    }
                    textiles.Dequeue();
                    medicaments.Pop();
                    remainingResourses += sum - 100;
                    int currMedicament = medicaments.Pop() + remainingResourses;
                    medicaments.Push(currMedicament);
                }
                else
                {
                    textiles.Dequeue();
                    remainingResourses = 10;
                    int currMedicament = medicaments.Pop() + remainingResourses;
                    medicaments.Push(currMedicament);
                }
            }
            if(medicaments.Count > 0 && textiles.Count == 0)
            {
                Console.WriteLine("Textiles are empty.");
            }
            if (medicaments.Count == 0 && textiles.Count > 0)
            {
                Console.WriteLine("Medicaments are empty.");
            }
            else if(medicaments.Count == 0 && textiles.Count == 0)
            {
                Console.WriteLine("Textiles and medicaments are both empty.");
            }
            var sortedDic = sorted.OrderByDescending(x => x.Value).ThenBy(x => x.Key);
            foreach (var item in sortedDic)
            {
                Console.WriteLine($"{item.Key} - {item.Value}");
            }
            if(medicaments.Count != 0)
            {
                Console.Write("Medicaments left: ");
                Console.Write(string.Join(", ", medicaments));
            }
            if (textiles.Count != 0)
            {
                Console.Write("Textiles left: ");
                Console.Write(string.Join(", ", textiles));
            }
        }
    }
}

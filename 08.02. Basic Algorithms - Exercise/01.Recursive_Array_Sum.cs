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
            int[] ints = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Console.WriteLine(SumArray(ints, 0));

        }
        static int SumArray(int[] ints, int index)
        {
            if(index == ints.Length)
            {
                return 0;
            }
            int sum = ints[index] + SumArray(ints, index + 1);
            return sum;
        }
    }
}

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
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(SumArray(n));

        }
        static int SumArray(int n)
        {
            if(n == 0)
            {
                return 1;
            }
            int sum = n * SumArray(n - 1);
            return sum;
        }
    }
}

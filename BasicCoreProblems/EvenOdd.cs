using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProblems
{
    internal class EvenOdd
    {
        public void CheckEvenOdd()
        {
            Console.WriteLine("Even Or Odd Program");
            Console.WriteLine("Enter the  number :");
            int n = Convert.ToInt32(Console.ReadLine());
            if (n % 2 == 0)
            {
                Console.WriteLine(n + " is an even number");
            }
            else
            {
                Console.WriteLine(n + " is an odd number");
            }
        }
    }
}

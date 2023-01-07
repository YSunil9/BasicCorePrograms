using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProblems
{
    internal class Factors
    {
        public void PrimeFactors()
        {
            Console.WriteLine("Prime factors of N");
            Console.WriteLine("Enter the value of N : ");
            int N = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Prime factors of the number are : ");
            for (int i = 2; N > 1; i++)
            {
                while (N % i == 0)
                {
                    N = N / i;
                    Console.WriteLine(i);
                }
            }
        }
    }
}

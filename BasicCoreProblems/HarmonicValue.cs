using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProblems
{
    internal class HarmonicValue
    {
        public void checkHarmonicValue()
        {
            Console.WriteLine("Enter value to find Harmonic Value");
            int n = Convert.ToInt32(Console.ReadLine());
            double sum = 0;
            for (int i = 1; i <= n; i++)
            {
                sum += 1 /(double)i;
                Console.Write("1/" + i + " " + "+ ");
            }
            Console.WriteLine("\n");
            Console.WriteLine("The nth Harmonic of n is: " + sum);
        }
    }
}


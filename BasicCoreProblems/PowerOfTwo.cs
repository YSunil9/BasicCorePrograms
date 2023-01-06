using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProblems
{
    internal class PowerOfTwo
    {
        public void PowerOf2()
        {
            int n;
            Console.WriteLine("Enter value of N");
            n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i<=n; i++)
            {
                double value = Math.Pow(2, i);
                Console.WriteLine("2 power of " + i + " is " + value);
            }
        }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProblems
{
    internal class SwapNumbers
    {
        public void Swap()
        {
            Console.WriteLine("Swap Two Numbers Program");
            Console.WriteLine("Enter the first number :");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number :");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Before swap a = " + a + ", b = " + b);
            int c;
            c = a;
            a = b;
            b = c;
            Console.WriteLine("After swap a = " + a + ", b = " + b);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProblems
{
    internal class QuotientRemainder
    {
        public void findQuotientAndRemainder()
        {
            Console.WriteLine("Enter Divident value");
            int divident = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Divisor value");
            int divisor = Convert.ToInt32(Console.ReadLine());
            int quotient = divident / divisor;
            int remainder = divident % divisor;
            Console.WriteLine("Quotient = " + quotient);
            Console.WriteLine("Remainder = " + remainder);
        }
    }
}

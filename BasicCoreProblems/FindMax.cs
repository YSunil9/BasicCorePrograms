using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProblems
{
    internal class FindMax
    {
        public void MaxOfThree()
        {
            Console.WriteLine("Largest Of Three Numbers Program");
            Console.WriteLine("Enter the values of a ,b and c\n");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            if (a > b && a > c)
            {
                Console.WriteLine(a +" is largest among three numbers.");
            }
            else if (b > c && b > a)
            {
                Console.WriteLine(b + " is largest among three numbers.");
            }
            else if(a==b && b==c)
            {
                Console.WriteLine("All Numbers are equal");
            }
            else
            {
                Console.WriteLine(c + " is largest among three numbers.");
            }
        }
    }
}

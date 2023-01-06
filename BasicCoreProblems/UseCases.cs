using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProblems
{
    internal class UseCases
    {
        public void FlipCoin()
        {
            int tail = 0, head = 0;
            Console.WriteLine("Enter number of times to flip");
            int n = Convert.ToInt32(Console.ReadLine());           
            for (int i = 0; i < n; i++)
            {
                Random random = new Random();
                int coinFlipped = random.Next(2);
                    if (coinFlipped < 0.5)
                    {
                        head++;
                    }
                    else
                    {
                        tail++;
                    }                
            }
            Console.WriteLine("Head: " + head);
            Console.WriteLine("Tail: " + tail);
            int headPercentage = head * 100 / n;
            Console.WriteLine("HeadsPercent = " + headPercentage + "%");
            int tailPercentage = tail * 100 / n;
            Console.WriteLine("TailsPercent = " + tailPercentage + "%");
        }
    }
}

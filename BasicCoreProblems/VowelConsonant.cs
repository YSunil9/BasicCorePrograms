using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProblems
{
    internal class VowelConsonant
    {
        public void Vowel()
        {
            Console.WriteLine("Vowel or Consonant Program");
            Console.WriteLine("Enter an alphabet :");
            char alphabet = Convert.ToChar(Console.ReadLine().ToLower());
            switch (alphabet)
            {
                case 'a':
                    Console.WriteLine(alphabet + " is an Vowel");
                    break;
                case 'e':
                    Console.WriteLine(alphabet + " is an Vowel");
                    break;
                case 'i':
                    Console.WriteLine(alphabet + " is an Vowel");
                    break;
                case 'o':
                    Console.WriteLine(alphabet + " is an Vowel");
                    break;
                case 'u':
                    Console.WriteLine(alphabet + " is an Vowel");
                    break;
                default:
                    Console.WriteLine(alphabet + " is an Consonant");
                    break;

            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _913_13.Vowel_or_Digit
{
    class Program
    {
        static void Main(string[] args)
        {
            string symbol = Console.ReadLine();

            if (symbol == "a" || symbol == "e" || symbol == "i" || symbol == "o" || symbol == "u")
            {
                Console.WriteLine("vowel");
            } 

            else if (symbol == 0.ToString() || symbol == 1.ToString() || symbol == 2.ToString() || symbol == 3.ToString() || symbol == 4.ToString() || symbol == 5.ToString() || symbol == 6.ToString() || symbol == 7.ToString() || symbol == 8.ToString() || symbol == 9.ToString())
            {
                Console.WriteLine("digit");
            }

            else
            {
                Console.WriteLine("other");
            }        
        }
    }
}

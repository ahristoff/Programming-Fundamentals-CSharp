using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_11.String_Concatenation
{
    class Program
    {
        static void Main(string[] args)
        {
            char symbol = char.Parse(Console.ReadLine());
            string evenOrOdd = Console.ReadLine().ToLower().Trim();
            int n = int.Parse(Console.ReadLine());

            string message = null;

            for (int i = 1; i <= n; i++)
            {
                string word = Console.ReadLine();

                if (evenOrOdd == "odd" && i % 2 == 1)
                {
                    message += word + symbol;                   
                }

                if (evenOrOdd == "even" && i % 2 == 0)
                {
                    message += word + symbol;
                }
            }

            Console.WriteLine(message.Substring(0, message.Length - 1));                                      
        }
    }
}

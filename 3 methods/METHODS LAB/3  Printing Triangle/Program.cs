using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3__Printing_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            PrintLine(number);
        }

        public static void PrintLine(int number)
        {
            PrintLineUp(number);
            PrintLineDown(number);
        }

        private static void PrintLineUp(int number)
        {
            for (int i = 1; i <= number; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(" {0}", j);
                }
                Console.WriteLine();
            }
        }

        private static void PrintLineDown(int number)
        {
            for (int i = 1; i <= number - 1; i++)
            {
                for (int j = 1; j <= number - i; j++)
                {
                    Console.Write(" {0}", j);
                }
                Console.WriteLine();
            }
        }
    }
}

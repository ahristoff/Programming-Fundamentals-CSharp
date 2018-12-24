using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Prime_Checker
{
    class Program
    {
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());

            GetOneOrZero(n);
            getAnotherDigit(n);
        }

        private static void getAnotherDigit(long n)
        {
            bool prime = true;           
            long divider = 2;

            while (divider<=Math.Sqrt(n))
            {

                if (n == 0 || n == 1)
                {
                    Console.WriteLine("False");
                }

                if (n % divider == 0)
                {
                    prime = false;
                    Console.WriteLine("False");
                    break;
                }
                divider++;
            }
            if (prime == true && n != 0 && n != 1)
            {
                Console.WriteLine("True");
            }
        }

        private static void GetOneOrZero(long n)
        {
            if (n == 0 || n == 1)
            {
                Console.WriteLine("False");
                
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.Primes_in_Given_Range
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());

            int oneOrTwo = 0;               //instead bool

            CalcAria(n1, n2, oneOrTwo);                      
        }

        private static void CalcAria(int n1, int n2, int oneOrTwo)
        {
            var list = new List<int>();

            if (n1 < 2)
            {
                list.Add(2);
            }

            for (int i = n1; i <= n2; i++)
            {

                for (int j = 2; j < i; j++)
                {

                    if (i % j == 0)
                    {
                        oneOrTwo = 1;
                        break;
                    }

                    else
                    {
                        oneOrTwo = 2;
                    }
                }

                if (oneOrTwo == 2 )
                {                    
                    list.Add(i);               
                }              
            }

            Console.Write(string.Join(", ", list));
            Console.WriteLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Fibonacci_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine(Calculations(n));
        }

        private static int Calculations(int n)
        {
            int sum = 1;
            int n1 = 0;
            int n2 = 1;

            for (int i = 1; i <= n; i++)
            {
                sum = n1 + n2;
                n1 = n2;
                n2 = sum;
            }

            return sum;
        }
    }
}

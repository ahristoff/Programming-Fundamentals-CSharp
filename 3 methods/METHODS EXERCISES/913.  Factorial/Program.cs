using System;
using System.Numerics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _913.Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger n = BigInteger.Parse(Console.ReadLine());

            BigInteger num = 1;
            BigInteger factoriel = 1;

            for (int i =1 ; i <= n; i++)
            {
                factoriel *= num;
                num++;
            }

            Console.WriteLine(factoriel);
        }
    }
}

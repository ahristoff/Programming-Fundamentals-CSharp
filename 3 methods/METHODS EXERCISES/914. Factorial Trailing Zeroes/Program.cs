using System;
using System.Numerics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _914.Factorial_Trailing_Zeroes
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger n = BigInteger.Parse(Console.ReadLine());

            BigInteger num = 1;
            BigInteger factoriel = 1;            
            
            Console.WriteLine(CheckCalc(GetFactoriel(n, num, factoriel)));
        }

        private static int CheckCalc(BigInteger factoriel)
        {
            int numberOfNull = 0;
            while (factoriel > 0)
            {
                if (factoriel % 10 != 0)
                {
                    break;
                }

                else if (factoriel % 10 == 0)
                {
                    numberOfNull++;
                }

                factoriel = factoriel / 10;
            }

            return numberOfNull;
        }

        private static BigInteger GetFactoriel(BigInteger n, BigInteger num, BigInteger factoriel)
        {

            for (int i = 1; i <= n; i++)
            {
                factoriel *= num;
                num++;
            }

            return factoriel;
        }
    }
}

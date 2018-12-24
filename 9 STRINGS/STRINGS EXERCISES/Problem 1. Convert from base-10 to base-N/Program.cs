using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
namespace Problem_1.Convert_from_base_10_to_base_N
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger[] read = Console.ReadLine().Split(' ').Select(BigInteger.Parse).ToArray();
            BigInteger n = read[0];

            BigInteger number = read[1];
            BigInteger remainder = 0;

            string result = string.Empty;

            while (number > 0)
            {
                remainder = number % n;
                number /= n;
                result = remainder.ToString() + result;
            }

            Console.WriteLine(result);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Problem_2.Convert_from_base_N_to_base_10
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ').ToList();
            int n = int.Parse(input[0]);

            char[] num = input[1].ToCharArray();

            BigInteger res = 0;

            for (int i = 0; i < num.Length; i++)
            {
                res += (int)Char.GetNumericValue(num[i]) * BigInteger.Pow(n , num.Length - i - 1);
            }

            Console.WriteLine(res);
        }
    }
}

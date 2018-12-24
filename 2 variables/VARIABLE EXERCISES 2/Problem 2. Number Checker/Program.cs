using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Problem_2.Number_Checker
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                BigInteger a = BigInteger.Parse(Console.ReadLine());
                Console.WriteLine("integer");
            }

            catch (Exception)
            {
                Console.WriteLine("floating-point");
            }         
        }
    }
}

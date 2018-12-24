using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Math_Power
{
    class Program
    {
        static void Main(string[] args)
        {
            double num = double.Parse(Console.ReadLine());
            int power = int.Parse(Console.ReadLine());

            
            Console.WriteLine(RaiseToPower(num, power));
        }

        public static double RaiseToPower(double num, int power)
        {
           double result = 1;

            for (int i = 1; i <= power; i++)
            {
                result *= num;
            }

            return result;
        }
    }
}

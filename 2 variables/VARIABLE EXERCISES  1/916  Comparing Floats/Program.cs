using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _916__Comparing_Floats
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());

            bool c = false;

            if (a - b < 0.000001 && a - b > -0.000001)
            {
                c = true;
            }

            Console.WriteLine(c);
        }
    }
}

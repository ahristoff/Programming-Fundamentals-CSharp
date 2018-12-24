using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _912_Rectangle_Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());

            double diagonal = Math.Sqrt(a * a + h * h);
            double aria = a * h;
            double perimeter = 2*( a + h);

            Console.WriteLine(perimeter);
            Console.WriteLine(aria);
            Console.WriteLine(diagonal);
        }
    }
}

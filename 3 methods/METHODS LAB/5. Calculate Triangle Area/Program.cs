using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Calculate_Triangle_Area
{
    class Program
    {
        public static void Main()
        {
            double height = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());

            double aria = GetTriangleAria(height, width);

            Console.WriteLine(aria);
        }

        public static double GetTriangleAria(double height, double width)
        {
            double aria = (height * width) / 2;
            return aria;
        }
    }
}

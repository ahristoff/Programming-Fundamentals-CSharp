using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Distance_Between_Points
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstPoint = Console.ReadLine().Split(' ');

            var first = new Point();
            first.x = double.Parse(firstPoint[0]);
            first.y = double.Parse(firstPoint[1]);

            var secondPoint = Console.ReadLine().Split(' ');

            var second = new Point();
            second.x = double.Parse(secondPoint[0]);
            second.y = double.Parse(secondPoint[1]);

            var result = Calc(first, second);

            Console.WriteLine($"{result:f3}");
        }



        public static double Calc(Point first, Point second)
        {
            var diffX = first.x - second.x;
            var diffY = first.y - second.y;

            var res = Math.Sqrt(Math.Pow(diffX, 2) + Math.Pow(diffY, 2));

            return res;
        }
    }
}


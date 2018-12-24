using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Intersection_of_Circles
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstCircle = Console.ReadLine().Split(' ');
            var secondCircle = Console.ReadLine().Split(' ');

            var first = new Point();
            first.x = double.Parse(firstCircle[0]);
            first.y = double.Parse(firstCircle[1]);
            first.radius = double.Parse(firstCircle[2]);
           
            var second = new Point();
            second.x = double.Parse(secondCircle[0]);
            second.y = double.Parse(secondCircle[1]);
            second.radius = double.Parse(secondCircle[2]);

            Calc(first, second);
        }

        private static void Calc(Point first, Point second)
        {
            var diffX = first.x - second.x;
            var diffY = first.y - second.y;

            var distanceBetweenCenters = Math.Sqrt(Math.Pow(diffX, 2) + Math.Pow(diffY, 2));

            var res = distanceBetweenCenters - (first.radius + second.radius);

            if (res > 0)
            {
                Console.WriteLine("No");
            }
            else
            {
                Console.WriteLine("Yes");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Closest_Two_Points
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var points = new List<Point>();

            for (int i = 0; i < n; i++)
            {
                var currPointParts = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();

                var currPoint = new Point();
                currPoint.x = currPointParts[0];
                currPoint.y = currPointParts[1];

                points.Add(currPoint);
            }

                var minDistanceSoFar = double.MaxValue;
                Point firstPointMin = null;
                Point secondPointMin = null;

            for (int i = 0; i < points.Count - 1; i++)
            {
                for (int j = i+1; j < points.Count; j++)
                {
                    var firstPoint = points[i];
                    var secondPoint = points[j];

                    var currentDistance = Calc(firstPoint, secondPoint);

                    if (currentDistance < minDistanceSoFar)
                    {
                        minDistanceSoFar = currentDistance;
                        firstPointMin = firstPoint;
                        secondPointMin = secondPoint;
                    }
                }
            }

                Console.WriteLine($"{minDistanceSoFar:f3}");
                Console.WriteLine($"({firstPointMin.x}, {firstPointMin.y})");
                Console.WriteLine($"({secondPointMin.x}, {secondPointMin.y})");         
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


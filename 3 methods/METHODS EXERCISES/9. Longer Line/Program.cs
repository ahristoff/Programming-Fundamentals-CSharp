﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.Longer_Line
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double x3 = double.Parse(Console.ReadLine());
            double y3 = double.Parse(Console.ReadLine());
            double x4 = double.Parse(Console.ReadLine());
            double y4 = double.Parse(Console.ReadLine());



            if (Math.Sqrt((x1-x2) * (x1 - x2) + (y1-y2)*(y1-y2))< Math.Sqrt((x3 - x4) * (x3 - x4) + (y3 - y4) * (y3 - y4)))
            {
                GetCoordinatSysSecondLine(x3, x4, y3, y4);
            }

            else if (Math.Sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2)) > Math.Sqrt((x3 - x4) * (x3 - x4) + (y3 - y4) * (y3 - y4)))
            {
                GetCoordinatSysFirstLine(x1, x2, y1, y2);
            }

            else if (Math.Sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2)) == Math.Sqrt((x3 - x4) * (x3 - x4) + (y3 - y4) * (y3 - y4)))
            {
                GetCoordinatSysFirstLine(x1, x2, y1, y2);
            }
        }

        private static void GetCoordinatSysFirstLine(double x1, double x2, double y1, double y2)
        {
            if (Math.Sqrt(x1 * x1 + y1 * y1) < Math.Sqrt(x2 * x2 + y2 * y2))
            {
                Console.WriteLine("({0}, {1})({2}, {3})", x1, y1,x2,y2);
            }

            else if (Math.Sqrt(x1 * x1 + y1 * y1) > Math.Sqrt(x2 * x2 + y2 * y2))
            {
                Console.WriteLine("({0}, {1})({2}, {3})", x2, y2,x1,y1);
            }

            else if (Math.Sqrt(x1 * x1 + y1 * y1) == Math.Sqrt(x2 * x2 + y2 * y2))
            {
                Console.WriteLine("({0}, {1})({2}, {3})", x1, y1, x2, y2);
            }
        }
        
        private static void GetCoordinatSysSecondLine(double x3, double x4 , double y3, double y4)
        {

            if (Math.Sqrt(x3 * x3 + y3 * y3) < Math.Sqrt(x4 * x4 + y4 * y4))
            {
                Console.WriteLine("({0}, {1})({2}, {3})", x3, y3, x4, y4);
            }

            else if (Math.Sqrt(x3 * x3 + y3 * y3) > Math.Sqrt(x4 * x4 + y4 * y4))
            {
                Console.WriteLine("({0}, {1})({2}, {3})", x4, y4, x3, y3);
            }

            else if (Math.Sqrt(x3 * x3 + y3 * y3) == Math.Sqrt(x4 * x4 + y4 * y4))
            {
                Console.WriteLine("({0}, {1})({2}, {3})", x3, y3, x4, y4);
            }
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _911.Geometry_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string nameOfFigure = Console.ReadLine();

            double res = CalculationFigurArea(nameOfFigure);

            Console.WriteLine("{0:f2}", res);
        }   

        private static double CalculationFigurArea(string nameOfFigure)
        {
            double area = 0;

            if (nameOfFigure == "triangle")
            {
                double side = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());

                area = (side * height) / 2;
            }

            else if (nameOfFigure == "square")
            {
                double side = double.Parse(Console.ReadLine());

                area = side * side;
            }

            else if (nameOfFigure == "rectangle")
            {
                double width = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());

                area = width * height;
            }

            else if (nameOfFigure == "circle")
            {
                double radius = double.Parse(Console.ReadLine());

                area = Math.PI * radius * radius;
            }

            return area;
        }
    }
 }


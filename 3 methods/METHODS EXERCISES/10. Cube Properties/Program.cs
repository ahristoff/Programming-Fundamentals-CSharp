using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Cube_Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            double length = double.Parse(Console.ReadLine());
            string name = Console.ReadLine();

            Console.WriteLine("{0:f2}", GetDate(length, name));            
        }

        private static double GetDate(double length, string name)
        {
            double res = 0;

            if (name == "face")
            {
                res = Math.Sqrt(2 * (length * length));
            }

            else if (name == "space")
            {
                res = Math.Sqrt(3 * (length * length));
            }

            else if (name == "volume")
            {
                res = length * length * length;
            }

            else if (name == "area")
            {
                res = 6 * (length * length);
            }

            return res;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_3.Megapixels
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal width = decimal.Parse(Console.ReadLine());
            decimal height = decimal.Parse(Console.ReadLine());

            Console.WriteLine("{0}x{1} => {2}MP", width, height, Math.Round((width * height) / 1000000,1));
        }
    }
}

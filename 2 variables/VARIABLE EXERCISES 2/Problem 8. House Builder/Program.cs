using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_8.House_Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            long n1 = long.Parse(Console.ReadLine());
            long n2 = long.Parse(Console.ReadLine());

            if (n1 <= 127 && n2 > 127)
            {
                Console.WriteLine(4 * n1 + 10 * n2);
            }

            if (n2 <= 127 && n1 > 127)
            {
                Console.WriteLine(10 * n1 + 4 * n2);
            }
        }
    }
}

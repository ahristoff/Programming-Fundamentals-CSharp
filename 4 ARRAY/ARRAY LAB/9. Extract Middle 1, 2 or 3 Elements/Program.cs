using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.Extract_Middle_1__2_or_3_Elements
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] num = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            if (num.Length == 1)
            {
                Console.Write("{ ");
                Console.Write("{0}", num[0]);
                Console.WriteLine(" }");
            }

            else if (num.Length != 1 && num.Length % 2 == 1)
            {
                Console.Write("{ ");
                Console.Write("{0}, {1}, {2}", num[(num.Length / 2) - 1], num[(num.Length / 2)], num[(num.Length / 2) + 1]);
                Console.WriteLine(" }");
            }

            else if (num.Length % 2 == 0)
            {
                Console.Write("{ ");
                Console.Write("{0}, {1}", num[(num.Length / 2) - 1], num[(num.Length / 2)]);
                Console.WriteLine(" }");
            }
        }
    }
}

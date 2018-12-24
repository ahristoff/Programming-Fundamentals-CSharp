using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_6.Interval_of_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine()); 

            for (int i = Math.Min(n1,n2); i <= Math.Max(n1,n2); i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}

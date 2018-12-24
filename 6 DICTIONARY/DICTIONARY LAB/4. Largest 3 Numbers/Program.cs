using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Largest_3_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            var output = input.OrderByDescending(n => n).Take(3).ToList();

            Console.WriteLine(string.Join(" ", output));
        }
    }
}

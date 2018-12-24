using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_1.Sort_Times
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = Console.ReadLine().Split(' ').OrderBy(l => l).ToList();
            Console.WriteLine(string.Join(", ",list));
        }
    }
}

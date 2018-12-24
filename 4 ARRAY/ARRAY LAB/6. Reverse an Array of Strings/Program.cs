using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Reverse_an_Array_of_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            var abc = Console.ReadLine().Split(' ').ToArray();

            var reversed = abc.Reverse();
            Console.WriteLine(String.Join(" ", reversed));
        }
    }
}

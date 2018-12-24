using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_strings_and_objects
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            string b = Console.ReadLine();

            string c = string.Format("{0} {1}", a, b);
            Console.WriteLine(c);

        }
    }
}

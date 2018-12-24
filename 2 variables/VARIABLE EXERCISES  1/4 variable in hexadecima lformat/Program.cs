using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_variable_in_hexadecima_lformat
{
    class Program
    {
        static void Main(string[] args)
        {
            string hexa = Console.ReadLine();
            int num = Convert.ToInt32(hexa, 16);
            

            Console.WriteLine(num);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _914__Integer_to_Hex_and_Binary
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string num16 = Convert.ToString(n,16).ToUpper();
            string num01 = Convert.ToString(n, 2);


            Console.WriteLine(num16);
            Console.WriteLine(num01);
        }
    }
}

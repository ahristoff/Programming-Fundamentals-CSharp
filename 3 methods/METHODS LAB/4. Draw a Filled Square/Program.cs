using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Draw_a_Filled_Square
{
    class Program
    {
        static void Main()
        {
            int num = int.Parse(Console.ReadLine());

            PrintHeader(num);
            PrintBody(num);
            PrintHeader(num);
        }

        private static void PrintHeader(int num)
        {
            Console.WriteLine("{0}",new string('-',2*num));
        }

        private static void PrintBody(int num)
        {
            for (int i = 1; i <= num-2 ; i++)
            {
                Console.WriteLine("-{0}-",string.Concat(Enumerable.Repeat("\\/",num-1)));
            }
        }     
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_914.Magic_Letter
{
    class Program
    {
        static void Main(string[] args)
        {
            char char1 = char.Parse(Console.ReadLine());
            char char2 = char.Parse(Console.ReadLine());
            char notprintedChar = char.Parse(Console.ReadLine());

            for (char i1 = char1; i1 <= char2; i1++)
            {
                for (char i2 = char1; i2 <= char2; i2++)
                {
                    for (char i3 = char1; i3 <= char2; i3++)
                    {
                        if (i1 != notprintedChar && i2 != notprintedChar&& i3 != notprintedChar)
                        {
                            Console.Write("{0}{1}{2} ", i1, i2, i3);
                        }
                    }
                }
            }
        }
    }
}

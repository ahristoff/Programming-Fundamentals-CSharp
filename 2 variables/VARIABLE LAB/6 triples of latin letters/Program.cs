using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_triples_of_latin_letters
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (var i1 = 'a'; i1 < 'a'+ n; i1++)
            {

                for (var i2 = 'a'; i2 < 'a' +n; i2++)
                {

                    for (var i3 = 'a'; i3 < 'a'+n ; i3++)
                    {
                        Console.WriteLine("{0}{1}{2}", i1, i2, i3);
                    }
                }
            }
        }
    }
}

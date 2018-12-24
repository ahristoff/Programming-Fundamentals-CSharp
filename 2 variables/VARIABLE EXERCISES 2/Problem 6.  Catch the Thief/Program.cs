using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_6.Catch_the_Thief
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            long countsOfIds = long.Parse(Console.ReadLine()); 

            var num = new List<long>();

            for (int i = 0; i < countsOfIds; i++)
            { 

               long id = long.Parse(Console.ReadLine());

                if (type == "sbyte" && id >= -128 && id <= 127)
                {
                   num.Add(id);
                }

                if (type == "int" && id >= int.MinValue && id <= int.MaxValue)
                {
                    num.Add(id);
                }

                if (type == "long" && id >= long.MinValue && id <= long.MaxValue)
                {
                    num.Add(id);
                }
            }

            var max = num.Max();

            Console.WriteLine(max);
        }
    }
}

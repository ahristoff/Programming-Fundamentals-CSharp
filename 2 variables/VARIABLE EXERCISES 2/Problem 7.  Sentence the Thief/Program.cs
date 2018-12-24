using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_7.Sentence_the_Thief
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine().ToLower().Trim();
            long n = long.Parse(Console.ReadLine()); 

            var num = new List<long>();

            for (int i = 0; i < n; i++)
            {
                long m = long.Parse(Console.ReadLine());

                if (type == "sbyte" && m >= -128 && m <= 127)
                {
                    num.Add(m);
                }

                if (type == "int" && m >= int.MinValue && m <= int.MaxValue)
                {
                    num.Add(m);
                }

                if (type == "long" && m >= long.MinValue && m <= long.MaxValue)
                {
                    num.Add(m);
                }
            }

            var max = num.Max();

            if (max>0)
            {

                if (Math.Ceiling(Math.Abs(max / 127.0)) > 1)
                {
                    Console.WriteLine("Prisoner with id {0} is sentenced to {1} years", max, (Math.Ceiling(Math.Abs(max / 127.0))));
                }

                if (Math.Ceiling(Math.Abs(max / 127.0)) == 1)
                {
                    Console.WriteLine("Prisoner with id {0} is sentenced to {1} year", max, (Math.Ceiling(Math.Abs(max / 127.0))));
                }
            }

            if (max<0)
            {

                if (Math.Ceiling(Math.Abs(max / -128.0)) > 1)
                {
                    Console.WriteLine("Prisoner with id {0} is sentenced to {1} years", max, (Math.Ceiling(Math.Abs(max / 127.0))));
                }

                if (Math.Ceiling(Math.Abs(max / -128.0)) == 1)
                {
                    Console.WriteLine("Prisoner with id {0} is sentenced to {1} year", max, (Math.Ceiling(Math.Abs(max / 127.0))));
                }
            }        
        }
    }
}

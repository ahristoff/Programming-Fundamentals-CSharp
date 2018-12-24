using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_5.Weather_Forecast
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                long n = long.Parse(Console.ReadLine());

                if (n >= -128 && n <= 127)
                {
                    Console.WriteLine("Sunny");
                }

                if ((n >= int.MinValue && n < sbyte.MinValue) || (n > sbyte.MaxValue && n < int.MaxValue))
                {
                    Console.WriteLine("Cloudy");
                }

                if ((n >= long.MinValue && n < int.MinValue) || (n > int.MaxValue && n < long.MaxValue))
                {
                    Console.WriteLine("Windy");
                }
            }

            catch 
            {
                Console.WriteLine("Rainy");
            }
        }
    }
}

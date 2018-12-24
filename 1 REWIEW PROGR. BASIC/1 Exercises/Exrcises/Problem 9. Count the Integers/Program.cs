using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_9.Count_the_Integers
{
    class Program
    {
        static void Main(string[] args)
        {                                   
            var integerCounter = 0;

            while (true)
            {

                try
                {
                    var n = int.Parse(Console.ReadLine());

                    integerCounter++;
                }

                catch
                {
                    Console.WriteLine(integerCounter);

                    break;
                }
            }
        }
    }
}

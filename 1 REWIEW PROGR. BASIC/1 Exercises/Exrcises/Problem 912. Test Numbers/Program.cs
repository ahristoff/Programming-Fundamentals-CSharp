using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_912.Test_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int M = int.Parse(Console.ReadLine());
            int boundary = int.Parse(Console.ReadLine());

            int count = 0;
            int sum = 0;

            for (int i = N; i >= 1; i--)
            {
                for (int j = 1; j <= M; j++)
                {
                    if (sum < boundary)
                    {

                        sum += 3 * i * j;
                        count++;                       
                    }

                    else
                    {
                        break;
                    }                                                                               
                }
            } 

            if (sum >= boundary)
            {

                Console.WriteLine("{0} combinations", count);
                Console.WriteLine("Sum: {0} >= {1}", sum, boundary);
            }

            if (sum < boundary)
            {

                Console.WriteLine("{0} combinations", count);
                Console.WriteLine("Sum: {0}", sum);
            }                  
        }
    }
}

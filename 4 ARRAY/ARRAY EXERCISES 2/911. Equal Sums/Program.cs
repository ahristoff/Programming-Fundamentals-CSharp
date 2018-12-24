using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _911.Equal_Sums
{
    class Program
    {
        static void Main(string[] args)

        {
            var arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int sumLeft = 0;
            int sumRight = 0;

            for (int x = 0; x < arr.Length; x++)
            {

                for (int i1 = 0; i1 < x; i1++)    
                {
                    sumLeft += arr[i1];
                }
                
                for (int i2 = x + 1; i2 < arr.Length; i2++)
                {
                    sumRight += arr[i2];
                }

                if (sumLeft == sumRight)
                {
                    Console.WriteLine(x);
                    return;  
                }

                else
                {
                    sumLeft = 0;
                    sumRight = 0;
                }
            }

            Console.WriteLine("no");
        }
    }
}

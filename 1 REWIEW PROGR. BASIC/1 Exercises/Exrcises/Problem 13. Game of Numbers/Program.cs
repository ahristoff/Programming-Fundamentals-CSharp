using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_13.Game_of_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int magicalNumber = int.Parse(Console.ReadLine());

            int combinationCount = 0;
            int conditionalCount = 0;          
            int n1 = 0;
            int m1 = 0;

            for (int i = n; i <= m; i++)
            {

                for (int j = n; j <= m; j++)
                {

                   combinationCount++;

                    if (i >= j && i + j == magicalNumber)
                    {

                        conditionalCount++;
                        n1 = i;
                        m1 = j;                                                                                  
                    }
                }
            }

            if (conditionalCount > 0)
            {
                Console.WriteLine("Number found! {0} + {1} = {2}", n1, m1, magicalNumber);
            }
            
            else if (conditionalCount == 0)
            {
                Console.WriteLine("{0} combinations - neither equals {1}", combinationCount, magicalNumber);      
            }
        }
    }
}

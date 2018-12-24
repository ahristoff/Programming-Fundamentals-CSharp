using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _910.Pairs_by_Difference
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int n = int.Parse(Console.ReadLine());

            int count = 0;

            for (int i = 0; i < num.Length; i++)
            {

                for (int j = 0; j < num.Length; j++)
                {

                    if (num[i] - num[j] == n)
                    {
                        count++;
                    }
                }              
            }
            Console.WriteLine(count);
        }
    }
}

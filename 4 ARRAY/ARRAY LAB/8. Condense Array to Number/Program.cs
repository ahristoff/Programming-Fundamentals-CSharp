using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.Condense_Array_to_Number
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] num = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();                       

            int[] condensed = new int[num.Length - 1];

            var sum = 0;

            if (num.Length == 1)
            {
                sum = num[0];
            }

            for (int i = 0; i < num.Length - 1; i++)
            {
                for (int j = 0; j < num.Length - 1 - i; j++)
                {
                    condensed[j] = num[j] + num[j + 1];
                    num[j] = condensed[j];
                    sum = condensed[j];
                }
            }

            Console.WriteLine(sum);           
        }
    }
}



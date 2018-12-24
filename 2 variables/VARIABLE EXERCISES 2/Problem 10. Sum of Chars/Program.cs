using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_10.Sum_of_Chars
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int totalSum = 0;

            for (int i = 0; i < n; i++)
            {

                char symbol = char.Parse(Console.ReadLine());

                totalSum += (int)symbol;               
            }

            Console.WriteLine("The sum equals: {0}",totalSum);
        }
    }
}

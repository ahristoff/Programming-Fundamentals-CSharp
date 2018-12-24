using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> num = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            int count = 0;
            int maxCount = -1;
            int end = -1;
            int start = -1;

            for (int i = 0; i < num.Count - 1; i++)
            {
                if (num[i] == num[i + 1])   //if == find Max_Sequence_of_Equal_Elements
                {                           //if > find Max_Sequence_of_Decreased_Elements
                    count++;                //if < find Max_Sequence_of_Increased_Elements

                    if (maxCount < count)
                    {
                        maxCount = count;
                        end = i;
                        start = end - maxCount;
                    }
                }

                else
                {
                    count = 0;
                }
            }

            for (int i = start; i <= end; i++)
            {
                Console.Write($"{num[i + 1]} ");
            }

            Console.WriteLine();
        }
    }
}

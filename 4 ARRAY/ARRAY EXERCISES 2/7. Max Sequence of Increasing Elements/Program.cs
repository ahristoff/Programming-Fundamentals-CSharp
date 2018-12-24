using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.Max_Sequence_of_Increasing_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int count = 0;
            int start = 0;
            int end = 0;
           
            for (int i = 1; i < arr.Length; i++)
            {

                if (arr[i]-arr[i-1] >= 1)
                {
                    count++;

                    if (count > end)
                    {
                        start = i-count;
                        end = count;                        
                    }                    
                }

                else
                {
                    count = 0;
                }
            }

            for (int i = start; i <= start + end; i++)
            {
                Console.Write($"{arr[i]} ");
            }
        }
    }
}

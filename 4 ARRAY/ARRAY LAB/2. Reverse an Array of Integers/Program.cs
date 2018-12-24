using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Reverse_an_Array_of_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] number = new int[n];

            for (int i = 0; i < number.Length; i++)
            {
                number[i] = int.Parse(Console.ReadLine());
            }

            for (int i = number.Length - 1; i >= 0; i--)       // 1 var.
            {
                Console.Write($"{number[i]} ");
            }

            //-------------------------------------------------------------

            //var reversed = number.Reverse();
            //Console.WriteLine(String.Join(" ",reversed));    // 2 var.

            //-------------------------------------------------------------

            //var reversed = new int[number.Length];           // 3 var
            //for (int i = 0; i < number.Length; i++)
            //{
            //    reversed[i] = number[number.Length - i - 1];
            //    Console.Write($"{reversed[i]} ");
            //}
        }
    }
}

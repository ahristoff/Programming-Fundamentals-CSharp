using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Fold_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
           
            int[] arr1 = new int[arr.Length/4];

            for (int i = 0; i < arr.Length / 4; i++)
            {
                arr1[i] = arr[i];               
            }
           
            int[] arr2 = new int[arr.Length / 2];

            for (int i = 0; i < arr.Length / 2; i++)
            {
                arr2[i] = arr[i+ arr.Length / 4];              
            }
        
            int[] arr3 = new int[arr.Length / 4];

            for (int i = 0; i < arr.Length / 4; i++)
            {
                arr3[i] = arr[i + (arr.Length / 4) + (arr.Length / 2)];           
            }

            int[] arr1Reversed = arr1.Reverse().ToArray();
            int[] arr3Reversed = arr3.Reverse().ToArray();

            int[] arrUpper = arr1Reversed.Concat(arr3Reversed).ToArray();
          
            int[] sum = arr2.ToArray();

            for (int i = 0; i < arr.Length / 2; i++)
            {
                sum[i] = arrUpper[i] + arr2[i];
                Console.Write($"{sum[i]} ");
            }
        }
    }
}

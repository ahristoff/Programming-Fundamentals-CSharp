using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {                                                       // var 1

            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();    

            int start = 0;
            int count = 0;
            int end = 0;
                
            for (int i = 0; i < arr.Length - 1; i++)
            {

                if (arr[i] == arr[i + 1])
                {
                    count++;

                    if (count > end)
                    {
                        start = i - count;
                        end = count;
                    }
                }

                else
                {
                    count = 0;
                }
            }

            if (end == 0)
            {
                Console.WriteLine(1);
            }

            else
            {
                for (int i = start + 1; i <= start + end + 1; i++)
                {
                    Console.Write(arr[i] + " ");
                }
            }

            //----------------------------------------------------------------- var 2

            //int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();  

            //var sum = 0;
            //var maxSum = int.MinValue;
            //int element = -1;

            //for (int i = 0; i < arr.Length - 1; i++)
            //{
            //    if (arr[i] == arr[i + 1])
            //    {
            //        sum++;

            //        if (sum > maxSum)
            //        {
            //            maxSum = sum;
            //            element = arr[i];
            //        }
            //    }

            //    else
            //    {
            //        sum = 0;
            //    }
            //}

            //var list = new List<int>();

            //for (int i = 0; i <= maxSum; i++)
            //{
            //    list.Add(element);
            //}

            //Console.WriteLine(string.Join(" ",list));
        }
    }
}

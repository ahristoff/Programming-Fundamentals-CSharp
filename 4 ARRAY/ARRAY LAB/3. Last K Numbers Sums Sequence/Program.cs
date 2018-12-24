using System;

namespace _3._Last_K_Numbers_Sums_Sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());

            int[] arr = new int[n];
            arr[0] = 1;
            arr[1] = 1;

            Console.Write($"{arr[0]} ");
            Console.Write($"{arr[1]} ");

            for (int i = 2; i < arr.Length; i++)
            {

                for (int j = 1; j <= k; j++)
                {

                    if (i - j < 0)
                    {
                        arr[i] = 2 * arr[i - 1];
                    }

                    else
                    {
                        arr[i] += arr[i - j];
                    }
                }

                Console.Write($"{arr[i]} ");
            }
        }
    }
}

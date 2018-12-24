using System;
using System.Linq;

namespace _4._Triple_Sum
{
    class Program
    {
        static void Main(string[] args)
        {           
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int p = 0;

            for (int i1 = 0; i1 < arr.Length; i1++)
            {

                for (int i2 = 0; i2 < arr.Length; i2++)
                {

                    for (int i3 = 0; i3 < arr.Length; i3++)
                    {

                        if (arr[i1] + arr[i2] == arr[i3] && i1 <= i2)
                        {

                            if (arr[i1] != arr[i2])
                            {
                                Console.WriteLine($"{arr[i1]} + {arr[i2]} == {arr[i3]}");

                                p = 1;
                            }
                        }
                    }
                }
            }

            if (p == 0)
            {
                Console.WriteLine("No");
            }
        }
    }
}

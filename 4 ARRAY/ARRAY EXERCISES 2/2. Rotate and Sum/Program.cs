using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Rotate_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var n = int.Parse(Console.ReadLine());

            int[] result = new int[nums.Length];

            for (int i = 0; i < n; i++)
            {
                var value = nums[nums.Length - 1];

                for (int j = nums.Length - 1; j > 0; j--)
                {
                    nums[j] = nums[j - 1];
                }

                nums[0] = value;

                for (int a = 0; a < nums.Length; a++)
                {
                    result[a] +=  nums[a];
                }
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}

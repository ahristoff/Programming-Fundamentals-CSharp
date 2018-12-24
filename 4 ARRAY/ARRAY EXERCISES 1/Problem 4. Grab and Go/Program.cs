using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_4.Grab_and_Go
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var num = int.Parse(Console.ReadLine());

            int count = 0;            
            int index = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (num == arr[i])
                {
                    count++;
                    index = i;
                }
            }

            long sum = 0;

            for (int i = 0; i < index; i++)
            {
                sum += arr[i];
                
            }

            string result = count > 0 ? sum.ToString() : "No occurrences were found!";

            Console.WriteLine(result);
        }
    }
}

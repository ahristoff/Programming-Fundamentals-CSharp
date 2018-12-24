using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Rounding_Numbers_Away_from_Zero
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] arr = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();

            int[] round = new int[arr.Length];

            for (int i = 0; i < arr.Length; i++)
            {
                round[i] = (int)Math.Round(arr[i], MidpointRounding.AwayFromZero);              
            }

            for (int i = 0; i < round.Length; i++)
            {
                Console.WriteLine("{0} => {0:f0}", arr[i], round[i]);
            }
        }
    }
}

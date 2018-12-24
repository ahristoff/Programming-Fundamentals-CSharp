using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.Index_of_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            var abc = Console.ReadLine();
            char[] arr = abc.ToCharArray();

            for (var i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"{arr[i]} -> {(int)arr[i] - 97}");
            }
        }
    }
}

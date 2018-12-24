using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_5.Pizza_Ingredients
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine().Split(' ').ToArray();
            var n = int.Parse(Console.ReadLine());

            var res = new List<string>();

            for (int i = 0; i < arr.Length; i++)
            {
               
                if (n == arr[i].Length) 
                {
                        Console.WriteLine("Adding {0}.", arr[i]);
                        res.Add(arr[i]);
                }

                if (res.Count() > 10)
                {
                    break;
                }
            }

            Console.WriteLine("Made pizza with total of {0} ingredients.", res.Count());
            Console.WriteLine("The ingredients are: {0}.", string.Join(", ", res));
        }
    }
}

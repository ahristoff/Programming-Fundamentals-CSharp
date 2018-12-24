using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace _5.Book_Library
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            
            var output = new Dictionary<string, double>();

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split(' ').ToList();
                var key = input[1];
                var value = double.Parse(input[5]);
                
                if (!output.ContainsKey(key))
                {
                    output[key] = 0;
                }                

                    output[key] += value;                                
            }
           
            foreach (var x in output.OrderByDescending(v => v.Value).ThenBy(v => v.Key))
            {
                Console.WriteLine($"{x.Key} -> {x.Value:f2}");
            }
        }
    }
}


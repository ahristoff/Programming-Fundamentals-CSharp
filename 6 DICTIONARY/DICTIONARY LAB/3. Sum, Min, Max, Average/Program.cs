using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Sum__Min__Max__Average
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<int> num = new List<int>();                     

            for (int i = 0; i < n; i++)
            {               
                num.Add(int.Parse(Console.ReadLine()));
            }
            
            var sum = num.Sum();
            Console.WriteLine("Sum = {0}",sum);
            var min = num.Min();
            Console.WriteLine("Min = {0}", min);
            var max = num.Max();
            Console.WriteLine("Max = {0}", max);
            var average = num.Average();
            Console.WriteLine("Average = {0}", average);
        }
    }
}

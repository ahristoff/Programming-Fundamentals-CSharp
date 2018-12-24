using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Square_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> num = Console.ReadLine().Split(' ').Select(int.Parse).OrderByDescending(n => n).ToList();

            var res = new List<int>();
           
            for (int i = 0; i < num.Count; i++)
            {
                if (num[i] % Math.Sqrt(num[i]) == 0)
                {
                    res.Add(num[i]);
                }
            }
           
            Console.WriteLine(string.Join(" ",res));
        }
    }
}

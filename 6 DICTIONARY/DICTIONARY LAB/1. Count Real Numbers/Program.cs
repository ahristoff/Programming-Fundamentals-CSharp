using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Count_Real_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<decimal> num = Console.ReadLine().Split(' ').Select(decimal.Parse).ToList();

            Dictionary<decimal, int> result = new Dictionary<decimal, int>();
            
            foreach (var x in num)
            {
                if (!result.ContainsKey(x))
                {
                    result[x] = 1;
                }
                else
                {
                    result[x]++;
                }
            }
           
            foreach (var y in result.OrderBy(n => n.Key))
            {
                Console.WriteLine("{0} -> {1}", y.Key, y.Value);         
            }           
        }
    }
}

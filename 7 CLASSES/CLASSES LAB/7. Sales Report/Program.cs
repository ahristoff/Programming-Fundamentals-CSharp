using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.Sales_Report
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var list = new List<Sale>();

            for (int i = 0; i < n; i++)
            {
                var currentSaleParts = Console.ReadLine().Split(' ');

                var currentSale = new Sale
                {
                    Town = currentSaleParts[0],                    
                    Price = decimal.Parse(currentSaleParts[2]),
                    Quatity = decimal.Parse(currentSaleParts[3]),
                    //Product = currentSaleParts[1]
                };

                list.Add(currentSale);
            }

            var result = new SortedDictionary<string, decimal>();

            foreach (var x in list)
            {
                if (!result.ContainsKey(x.Town))
                {
                    result[x.Town] = 0;
                }

                result[x.Town] += x.Price * x.Quatity;
            }

            foreach (var y in result)
            {
                Console.WriteLine($"{y.Key:f2} -> {y.Value:f2}");
            }
        }
    }
}

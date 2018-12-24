using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_912._Beer_Kegs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var dict = new Dictionary<double, string>();

            for (int i = 0; i < n; i++)
            {

                string model = Console.ReadLine();
                double rad = double.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());

                double vol = Math.PI * rad * rad * height;

                dict[vol] = model;
            }

            var res = dict.OrderByDescending(d => d.Key).Take(1);

            foreach (var x in res)
            {
                Console.WriteLine("{0}", x.Value);
            }
        }
    }
}

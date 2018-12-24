using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_7.Inventory_Matcher
{
    class Program
    {
        static void Main(string[] args)
        {
            var productName = Console.ReadLine().Split(' ').ToList();
            var quantity = Console.ReadLine().Split(' ').ToArray();
            var price = Console.ReadLine().Split(' ').ToArray();
          
            var comand = Console.ReadLine();

            while (comand != "done")
            {

                var res = productName.IndexOf(comand);
                
                var qvn = quantity[res];
                var prc = price[res];

                Console.WriteLine("{0} costs: {1}; Available quantity: {2}", comand, prc, qvn);

                comand = Console.ReadLine();
            }
        }
    }
}

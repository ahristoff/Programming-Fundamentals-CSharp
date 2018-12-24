using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_8.___Upgraded_Matcher
{
    class Program
    {
        static void Main(string[] args)
        {
            var productName = Console.ReadLine().Split(' ').ToList();
            var quantity = Console.ReadLine().Split(' ').Select(long.Parse).ToList();
            var price = Console.ReadLine().Split(' ').Select(decimal.Parse).ToList();

            var diff = productName.Count - quantity.Count;

            for (int i = 0; i < diff; i++)
            {
                quantity.Add(0);
            }

            var comand = Console.ReadLine();

            while (comand!="done")
            {

                var input = comand.Split(' ').ToList();
                long inputQuantity = long.Parse(input[1]);

                var indexOfProductName = productName.IndexOf(input[0]);
                
                var qvn = quantity[indexOfProductName];
                var prc = price[indexOfProductName];

                if (inputQuantity > qvn)
                {
                    Console.WriteLine("We do not have enough {0}",input[0]);                                     
                }

                else
                {
                    Console.WriteLine("{0} x {1} costs {2:f2}", input[0], input[1], inputQuantity * prc);
                    quantity[indexOfProductName] = qvn - inputQuantity;
                }       
                
                comand = Console.ReadLine();
            }
        }
    }
}

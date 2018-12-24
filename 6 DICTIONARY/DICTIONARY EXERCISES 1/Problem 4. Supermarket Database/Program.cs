using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_4.Supermarket_Database
{
    class Program
    {
        static void Main(string[] args)
        {
            var nestedDict = new Dictionary<string, Dictionary<decimal, decimal>>();

            var comand = Console.ReadLine();

            while (comand != "stocked")
            {
                var com = comand.Split(' ');

                string name = com[0];
                decimal price = decimal.Parse(com[1]);
                int quantity = int.Parse(com[2]);


                if (!nestedDict.ContainsKey(name))
                {
                    nestedDict[name] = new Dictionary<decimal, decimal>();
                }

                if (!nestedDict[name].ContainsKey(price))
                {
                    nestedDict[name][price] = 0;
                }
                nestedDict[name][price] = quantity;

                comand = Console.ReadLine();
            }

            decimal totalSum = 0;

            foreach (var x in nestedDict)
            {
                Console.WriteLine("{0}: ${1:f2} * {2} = ${3}",
                    x.Key, x.Value.Keys.Last(), x.Value.Values.Sum(), x.Value.Keys.Last() * x.Value.Values.Sum());

                totalSum += x.Value.Keys.Last() * x.Value.Values.Sum();
            }

            Console.WriteLine("{0}", new string('-', 30));
            Console.WriteLine("Grand Total: ${0}", totalSum);           
        }
    }
}

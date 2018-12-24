using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.A_Miner_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, decimal> resources = new Dictionary<string, decimal>();

            var line = Console.ReadLine();

            while (line != "stop")
            {
                var resource = line;
                var quantity = decimal.Parse(Console.ReadLine());

                if (!resources.ContainsKey(resource))
                {
                    resources[resource] = 0;
                }

                resources[resource] += quantity;

                line = Console.ReadLine();
            }

            foreach (var x in resources)
            {
                Console.WriteLine($"{x.Key} -> {x.Value}");
            }
            
        }
    }
}

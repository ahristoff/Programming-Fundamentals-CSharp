using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._Andrey_and_billiard
{
    class Program
    {
        static void Main(string[] args)
        {
            var dict = new Dictionary<string, Dictionary<string, int>>();
            var dictStock = new Dictionary<string, decimal>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var stock = Console.ReadLine().Split('-').ToList();

                string produkt = stock[0];
                decimal price = decimal.Parse(stock[1]);

                if (!dictStock.ContainsKey(produkt))
                {
                    dictStock[produkt] = 0;
                }
                dictStock[produkt] = price;
            }

            var comand = Console.ReadLine();

            while (comand != "end of clients")
            {
                var nameStock = comand.Split(new[] { '-', ',' }, StringSplitOptions.RemoveEmptyEntries).ToList();

                string name = nameStock[0];
                string prod = nameStock[1];
                int quantity = int.Parse(nameStock[2]);

                if (!dict.ContainsKey(name))
                {
                    dict[name] = new Dictionary<string, int>();
                }

                if (!dict[name].ContainsKey(prod))
                {
                    dict[name][prod] = 0;
                }

                dict[name][prod] += quantity;

                comand = Console.ReadLine();
            }

            decimal sum = 0;


            foreach (var x in dict.OrderBy(s => s.Key))
            {

                foreach (var y in x.Value)
                {

                    foreach (var z in dictStock)
                    {

                        if (y.Key == z.Key)
                        {

                            Console.WriteLine(x.Key);

                            Console.WriteLine("-- {0} - {1}", y.Key, y.Value);
                            Console.WriteLine("Bill: {0:f2}", y.Value * z.Value);

                            sum += y.Value * z.Value;
                        }
                    }
                }
            }

            Console.WriteLine("Total bill: {0:f2}", sum);
        }
    }
}

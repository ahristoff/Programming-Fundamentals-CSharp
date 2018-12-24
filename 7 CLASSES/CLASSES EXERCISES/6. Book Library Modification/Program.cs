using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace _6.Book_Library_Modification
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
           
            var output = new Dictionary<string, DateTime>();          

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split(' ').ToList();

                var value = input[0];

                DateTime key = DateTime.ParseExact(input[3], "dd.MM.yyyy", CultureInfo.InvariantCulture);
               
                output[value] = key;
            }
            
            DateTime border = DateTime.ParseExact(Console.ReadLine(), "dd.MM.yyyy", CultureInfo.InvariantCulture);
 
            foreach (var x in output.OrderBy(x => x.Value).ThenBy(p => p.Key))
            {
                int result = DateTime.Compare(border, x.Value);

                if (result < 0)
                {
                    Console.WriteLine($"{x.Key} -> {x.Value.ToString("dd.MM.yyyy")}");
                }               
            }
        }
    }
}

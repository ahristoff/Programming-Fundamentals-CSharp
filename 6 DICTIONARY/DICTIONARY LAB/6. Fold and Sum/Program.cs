using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Fold_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> num = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            var a = num.Take(num.Count / 4).Reverse();                                    
            var b = num.Skip((3 * num.Count ) / 4).Take(num.Count / 4).Reverse();

            var firstRow = a.Concat(b);
            var secondRow = num.Skip(num.Count / 4).Take(num.Count / 2);

            var result = firstRow.Zip(secondRow, (x, y) => x + y);

            Console.WriteLine(string.Join(" ",result));
        }
    }
}

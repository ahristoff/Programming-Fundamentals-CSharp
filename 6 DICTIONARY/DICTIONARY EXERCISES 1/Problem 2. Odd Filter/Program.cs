using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_2._Odd_Filter
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            var res = new List<int>();

            list.RemoveAll(x => x % 2 == 1);
            var num = list.Average();

            for (int i = 0; i < list.Count; i++)
            {

                if (list[i] > num)
                {
                    res.Add(list[i] + 1);
                }

                if (list[i] <= num)
                {
                    res.Add(list[i] - 1);
                }
            }

            Console.WriteLine(string.Join(" ", res));
        }
    }
}

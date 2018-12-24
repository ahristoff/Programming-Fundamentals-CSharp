using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._Remove_Negatives_and_Reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> num = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            num.RemoveAll(x => x <= 0);
            num.Reverse();

            if (num.Count == 0)
            {
                Console.WriteLine("empty");
            }

            Console.WriteLine(string.Join(" ", num));
        }
    }
}

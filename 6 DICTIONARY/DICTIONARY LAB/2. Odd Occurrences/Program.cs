using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Odd_Occurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> word = Console.ReadLine().ToLower().Split(' ').ToList();

            Dictionary<string, int> abc = new Dictionary<string, int>();

            foreach (var x in word)
            {
                if (!abc.ContainsKey(x))
                {
                    abc[x] = 1;
                }
                else
                {
                    abc[x]++;
                }
            }

            var result = new List<string>();

            foreach (var y in abc)
            {
                if (y.Value % 2 != 0)
                {
                    result.Add(y.Key);                   
                }
            }
            Console.WriteLine(string.Join(", ",result));
        }
    }
}

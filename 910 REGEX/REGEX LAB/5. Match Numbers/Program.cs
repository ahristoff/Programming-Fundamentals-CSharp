using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _5.Match_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<string>();
            var input = Console.ReadLine();

            var reg = new Regex(@"\b(\d+(\.|)(\d+|))\b");

            var res = reg.Matches(input);

            foreach (Match x in res)
            {
                list.Add(x.Value.Trim());
            }

            list = list.Distinct().ToList();


            Console.WriteLine(string.Join(" ", list));
        }
    }
}

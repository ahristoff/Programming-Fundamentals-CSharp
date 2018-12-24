using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _3.Match_Hexadecimal_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<string>();
            string input = Console.ReadLine();

            var reg = new Regex(@"\b(?:0x)?[0-9A-F]+\b");

            var matches = reg.Matches(input);

            foreach (Match x in matches)
            {
                list.Add(x.Value.Trim());
            }

            list = list.Distinct().ToList();

            Console.WriteLine(string.Join(" ", list));
        }
    }
}

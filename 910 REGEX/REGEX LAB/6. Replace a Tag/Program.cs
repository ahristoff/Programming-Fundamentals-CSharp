using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _6._Replace_a_Tag
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            var reg = new Regex(@"<a.*href=(""|')(.*)\1>(.*?)<\/a>");
            var matches = reg.Matches(input);

            var result = reg.Replace(input, @"[URL href=""$2"">$3[/URL]");

            Console.WriteLine(result);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _1.Match_full_name
{
    class Program
    {
        static void Main(string[] args)
        {

            var input = Console.ReadLine();

            var list = new List<string>();

            var reg = new Regex(@"\b[A-Z][a-z]+ [A-Z][a-z]+\b");
            var result1 = reg.Matches(input);

            foreach (Match x in result1)
            {
                Console.Write(x + " ");
            }
        }
    }
}
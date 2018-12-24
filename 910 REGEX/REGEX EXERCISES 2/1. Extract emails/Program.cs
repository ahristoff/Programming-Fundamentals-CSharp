using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _1.Extract_emails
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            var regText = @"((?<=\s)[a-zA-Z0-9]+([-.]\w*)*@[a-zA-Z]+?([.-][a-zA-Z]*)*(\.[a-z]{2,}))";
            Regex reg = new Regex(regText);
            var output = reg.Matches(input);

            foreach (Match x in output)
            {              
                Console.WriteLine(x.Value);
            }
        }
    }
}

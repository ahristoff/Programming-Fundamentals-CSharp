using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
namespace _4.Match_Dates
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var reg = new Regex(@"\b(\d{2})([/.-])([A-Z][a-z]{2})\2(\d{4})\b");

            var matches = reg.Matches(input);

            foreach (Match x in matches)
            {
                Console.WriteLine("Day: {0}, Month: {1}, Year: {2}",x.Groups[1].Value,x.Groups[3].Value,x.Groups[4].Value);
            }
        }
    }
}

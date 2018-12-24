using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _2.Match_phone_number
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<string>();

            var input = Console.ReadLine();

            var reg = new Regex(@"\+359(\s|-)\d{1}\1\d{3}\1\d{4}");
            var res = reg.Matches(input);

            foreach (Match x in res)
            {
                list.Add(x.Value.Trim());
            }
          
            Console.WriteLine(string.Join(" ", list.Distinct()));        
        }
    }
}

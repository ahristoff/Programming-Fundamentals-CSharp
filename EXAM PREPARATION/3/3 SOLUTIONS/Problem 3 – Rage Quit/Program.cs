using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Problem_3___Rage_Quit
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().ToUpper();
            
            var dig = new Regex(@"\d+");
            var matches1 = dig.Matches(input);

            var listDigit = new List<int>();

            foreach (Match x in matches1)
            {
                listDigit.Add(int.Parse(x.Value));                
            }
            
            var sym = new Regex(@"[^0-9]+");
            var matches2 = sym.Matches(input);

            var listLetter = new List<string>();

            foreach (Match x in matches2)
            {
                listLetter.Add(x.Value);
            }       

            var sb = new StringBuilder();

            for (int i = 0; i < listDigit.Count; i++)
            {
                for (int j = 0; j < listDigit[i]; j++)
                {
                    sb.Append(listLetter[i]);
                }
            }

            string result = sb.ToString();
            var totalResult = result.Distinct().ToList();
            
            Console.WriteLine("Unique symbols used: {0}", totalResult.Count);
            Console.WriteLine(sb.ToString());
        }
    }
}

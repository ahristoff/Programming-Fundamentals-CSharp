using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _5.Key_Replacer
{
    class Program
    {
        static void Main(string[] args)
        {
            var keyInput = Console.ReadLine()
                .Split(new char [] {'\\', '<', '|'},StringSplitOptions.RemoveEmptyEntries);
            var text = Console.ReadLine();          

            string start = keyInput[0];
            string end = keyInput[2];
           
            Regex reg = new Regex($"{start}(.*?){end}");           
            var matches = reg.Matches(text);

            string result = "";

            foreach (Match x in matches)
            {
                Regex regex = new Regex($"{start}(.*?){end}");
                Match match = regex.Match(x.Value);
                result += match.Groups[1].Value;
            }
          
            if (result == string.Empty)
            {
                Console.WriteLine("Empty result");
            }

            else
            {
                Console.WriteLine(result);
            }
        }
    }
}

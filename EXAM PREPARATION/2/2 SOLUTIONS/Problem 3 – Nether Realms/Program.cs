using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;



class Program
{
    static void Main(string[] args)
    {
        var demons = Console.ReadLine()
            .Split(new[] { ',', ' ', '\t', '\n' }, StringSplitOptions.RemoveEmptyEntries).ToList();

        long resHealth = 0;
        decimal resDamage = 0;

        foreach (var x in demons.OrderBy(s => s))
        {         
            var digit = new Regex(@"(\+|-|)(\d+(\.|)\d+|\d)");
            var matches1 = digit.Matches(x);

            foreach (Match a in matches1)
            {
                resDamage += decimal.Parse(a.Value);
            }
         
            var symbol = new Regex(@"\*|\/");
            var matches2 = symbol.Matches(x);

            foreach (Match b in matches2)
            {
                if (b.Value == "*")
                {
                    resDamage *= 2;
                }

                else if (b.Value == "/")
                {
                    resDamage /= 2M;
                }
            }

            var letter = new Regex(@"[^0-9\+\-\*\/\.]");
            var matches3 = letter.Matches(x);

            foreach (Match c in matches3)
            {
                resHealth += (int)(char.Parse(c.Value));
            }

            Console.WriteLine("{0} - {1} health, {2:f2} damage", x, resHealth, resDamage);

            resHealth = 0;
            resDamage = 0;
        }
    }
}



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _6.Email_Statistics
{
    class Program
    {
        static void Main(string[] args)
        {
            var dict = new Dictionary<string, List<string>>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var email = Console.ReadLine();

                var reg = new Regex(@"^([A-Za-z]{5,})@([a-z]{3,}(.com|.bg|.org))$");

                var matches = reg.Match(email);

                if (!reg.IsMatch(email))
                {
                    continue;
                }

                Match match = reg.Match(email);
                var name = match.Groups[1].Value;
                var domain = match.Groups[2].Value;

                if (!dict.ContainsKey(domain))
                {
                    dict.Add(domain, new List<string>());
                }

                if(!dict[domain].Contains(name))
                {
                    dict[domain].Add(name);
                }
            }

            foreach (var x in dict.OrderByDescending(s=>s.Value.Count()))
            {
                Console.WriteLine(x.Key + ':');

                for (int i = 0; i < x.Value.Count; i++)
                {
                    Console.WriteLine("### "+x.Value[i]);
                }
            }
        }
    }
}

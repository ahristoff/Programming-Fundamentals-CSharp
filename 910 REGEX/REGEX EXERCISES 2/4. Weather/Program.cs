using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _4.Weather
{
    class Program
    {
        static void Main(string[] args)
        {
            var dict = new Dictionary<string, Dictionary<double, string>>();

            var comand = Console.ReadLine();

            Regex reg = new Regex(@"([A-Z]{2})([0-9]+\.[0-9]{1,2})([A-Za-z]+)\|");

            while (comand != "end")
            {
                Match matches = reg.Match(comand);

                if (reg.IsMatch(comand))
                {

                    string city = matches.Groups[1].Value;
                    double temp = double.Parse(matches.Groups[2].Value);
                    string station = matches.Groups[3].Value;

                    if (!dict.ContainsKey(city))
                    {
                        dict[city] = new Dictionary<double, string>();
                    }

                    if (!dict[city].ContainsKey(temp))
                    {
                        dict[city][temp] = "";
                    }

                    dict[city][temp] = station;
                }

                comand = Console.ReadLine();
            }

            foreach (var city in dict.OrderBy(s => s.Value.Keys.Min()))
            {
                Console.WriteLine("{0} => {1:f2} => {2}", city.Key, city.Value.Keys.Last(), city.Value.Values.Last());
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _7.Hideout
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var list = Console.ReadLine();

            while (true)
            {
                var elements = list.Split(' ').ToList();

                char sym = char.Parse(elements[0]);
                var num = int.Parse(elements[1]);


                var reg = new Regex($"\\{sym}{{{num},}}");
                var matches = reg.Matches(input);

                if (!reg.IsMatch(input))
                {
                    list = Console.ReadLine();
                    continue;
                }

                else
                {
                    var index = -2;
                    var length = -2;

                    foreach (Match x in matches)
                    {
                        index = input.IndexOf(x.Value);
                        length = x.Value.Length;
                    }

                    Console.WriteLine("Hideout found at index {0} and it is with size {1}!", index, length);

                    break;
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Censorship
{
    class Program
    {
        static void Main(string[] args)
        {
            var word = Console.ReadLine();
            var sentance = Console.ReadLine();

            if (sentance.IndexOf(word) < 0)
            {
                word = word.ToLower();
            }

            var res = sentance.Replace(word, new string('*', word.Length));

            Console.WriteLine(res);
        }
    }
}

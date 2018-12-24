using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Randomize_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            var words = Console.ReadLine().Split(' ');
            var rdn = new Random();

            for (int i = 0; i < words.Length; i++)
            {
                var currWord = words[i];
                var random = rdn.Next(0, words.Length);

                var randWord = words[random];

                words[i] = randWord;
                words[random] = currWord; 
            }

            foreach (var x in words)
            {
                Console.WriteLine(x);
            }
        }
    }
}

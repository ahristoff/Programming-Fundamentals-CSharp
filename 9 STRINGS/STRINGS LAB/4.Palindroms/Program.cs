using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Palindroms
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine().Split(new Char[] { ' ', ',', '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);

            var palindromes = new List<string>();

            foreach (var x in text)
            {
                int startWord = 0;
                int endWord = x.Length - 1;
                int count = 0;

                for (int i = 0; i < x.Length / 2; i++)
                {
                    if (x[startWord] == x[endWord])
                    {
                        startWord++;
                        endWord--;
                        count++;
                    }
                }

                if (count == x.Length / 2)
                {
                    palindromes.Add(x);
                }
            }
            var sortedPalindromes = palindromes.OrderBy(n => n).Distinct();

            Console.WriteLine(string.Join(", ", sortedPalindromes));
        }
    }
}

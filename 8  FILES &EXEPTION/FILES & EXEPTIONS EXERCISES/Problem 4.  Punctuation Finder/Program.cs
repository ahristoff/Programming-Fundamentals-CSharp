using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Problem_4.Punctuation_Finder
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = File.ReadAllText("../../input.txt");       
            
            var input = text.Replace(" ", string.Empty).ToList();

            var punct = new List<char>();

            for (int i = 0; i < input.Count; i++)
            {
                if (input[i]=='.'|| input[i] == ','|| input[i] == '!' || input[i] == '?'|| input[i] == ':')
                {
                    punct.Add(input[i]);
                }
            }

            File.WriteAllText("../../output.txt", string.Join(", ", punct));

            Console.WriteLine(File.ReadAllText("../../output.txt"));
        }
    }
}

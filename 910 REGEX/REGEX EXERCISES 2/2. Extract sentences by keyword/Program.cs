using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _2.Extract_sentences_by_keyword
{
    class Program
    {
        static void Main(string[] args)
        {

            string key = Console.ReadLine();
            var input = Console.ReadLine()
                .Split(new[] { '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries).ToList();

            Regex regText = new Regex($"[^.!?;]*(({key}\\W)|(\\W{key}\\W))[^.!?;]*");

            for (int i = 0; i < input.Count; i++)
            {
                if (regText.IsMatch(input[i]))
                {
                    Console.WriteLine(input[i].Trim());
                }
            }
        }
    }
}

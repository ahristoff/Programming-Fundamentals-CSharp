using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _1.Odd_Lines
{
    class Program
    {
        static void Main(string[] args)
        {
            var lines = File.ReadAllLines("input.txt");

            var oddLines = new List<string>();

            for (int i = 1; i <= lines.Length - 1; i++)
            {
                if (i % 2 == 1)
                {
                    oddLines.Add(lines[i]);
                }

            }
            File.WriteAllLines("output.txt", oddLines);

            Console.WriteLine(string.Join("\r\n", oddLines));






            //var text = File.ReadAllText("input.txt");

            //Console.WriteLine(text);

            //var input = text.Replace(" ", string.Empty).ToList();

            //var punct = new List<char>();

            //for (int i = 0; i < input.Count; i++)
            //{
            //    if (!char.IsLetter(input[i]))
            //    {
            //        punct.Add(input[i]);
            //    }
            //}

            //File.WriteAllText("output.txt", string.Join(",", punct));

            //Console.Write(string.Join(",", punct));
        }
    }
}

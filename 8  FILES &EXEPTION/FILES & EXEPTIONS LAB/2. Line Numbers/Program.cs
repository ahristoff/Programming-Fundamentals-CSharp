using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _2.Line_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var lines = File.ReadAllLines("input.txt");

            var listLines = new List<string>();

            for (int i = 0; i <lines.Length ; i++)
            {
                listLines.Add($"{i+1}. {lines[i]}");
            }

            File.WriteAllLines("output.txt", listLines);

            Console.WriteLine(string.Join("\r\n", listLines));
        }
    }
}

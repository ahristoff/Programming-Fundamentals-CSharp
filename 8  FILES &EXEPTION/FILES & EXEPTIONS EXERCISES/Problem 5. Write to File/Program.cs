using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Problem_5.Write_to_File
{
    class Program
    {
        static void Main(string[] args)
        {
            var inpuTtext = File.ReadAllText("../../input.txt");

            var text = inpuTtext.Split(new[] { '.', ',', '!', '?', ':' }, StringSplitOptions.RemoveEmptyEntries);

            File.WriteAllText("../../output.txt", string.Join("", text));

            Console.WriteLine(File.ReadAllText("../../output.txt"));
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _3.Word_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            var words = File.ReadAllText("words.txt").Split(new char[] {' ', '\r','\n' },StringSplitOptions.RemoveEmptyEntries).Select(n=>n.ToLower()).ToList();

            var input = File.ReadAllText("input.txt").Split(new char[] { ' ', '.', ',', '!', '?', '-', '\'',  '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries).Select(n => n.ToLower()).ToList();

            var res = new Dictionary<string, int>();
            
            for (int i = 0; i < words.Count; i++)
            {
                var a = 0;
                for (int j = 0; j < input.Count; j++)
                {
                    if (words[i] == input[j])
                    {
                        a++;                        
                    }                    
                }

                res[words[i]] = a;        
            }

            var sortedres = res.OrderByDescending(n => n.Value).Select(n => $"{n.Key} - {n.Value}");

            File.WriteAllLines("output.txt", sortedres);

            Console.WriteLine(string.Join("\r\n", sortedres));
        }
    }
}

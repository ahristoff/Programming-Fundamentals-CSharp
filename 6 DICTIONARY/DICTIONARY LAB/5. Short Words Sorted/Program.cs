using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Short_Words_Sorted
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> text = Console.ReadLine().ToLower().Split(new Char[] { ',', ';', ':', '.', '!', '(', ')', '"', '\'', '\\', '/', '[', ']', '?', ' ' }, StringSplitOptions.RemoveEmptyEntries)
             
            .Where(n => n.Length < 5)           
            .Distinct()
            .OrderBy(v => v)
            .ToList();           
            
            Console.WriteLine(string.Join(", ",text));                        
        }
    }
}

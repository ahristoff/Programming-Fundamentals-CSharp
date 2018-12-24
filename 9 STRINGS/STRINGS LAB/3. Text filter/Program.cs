using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Text_filter
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine().Split(new Char[] { ' ', ',' }, StringSplitOptions. RemoveEmptyEntries);
            var filterWords = Console.ReadLine();
            
            var replaced = string.Empty;

            foreach (var x in text)
            {               
                replaced = filterWords.Replace(x, new string('*', x.Length));  
            }

            Console.WriteLine(replaced);          
        }
    }
}

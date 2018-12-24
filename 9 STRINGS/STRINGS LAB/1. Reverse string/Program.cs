using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Reverse_string
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine();
            var reversedText = text.Reverse().ToArray();
            Console.WriteLine(reversedText);           
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.___Append_Lists
{
    class Program
    {
        static void Main(string[] args)
        {           
            var num = Console.ReadLine().Split(new[] { '|' }, StringSplitOptions.RemoveEmptyEntries)
                .Reverse().ToList();
            
            var result = string.Empty;

            for (int i = 0; i < num.Count; i++)
            {
                var currentString = num[i].Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                for (int j = 0; j < currentString.Length; j++)
                {
                    result += currentString[j] + " ";
                }
            }

            Console.WriteLine(result);
        }
    }
}

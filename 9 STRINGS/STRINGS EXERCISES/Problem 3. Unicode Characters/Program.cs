using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_3._Unicode_Characters
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var res = new List<string>();

            for (int i = 0; i < input.Length; i++)
            {
                string num = Convert.ToString(input[i], 16);
                num = "\\u00" + num;
                res.Add(num);
            }

            Console.WriteLine(string.Join("", res));
        }
    }
}

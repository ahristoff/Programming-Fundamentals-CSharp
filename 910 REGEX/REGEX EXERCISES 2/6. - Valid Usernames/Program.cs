using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _6.___Valid_Usernames
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()
                .Split(new[] { ' ', '\\', '/', '(', ')' }, StringSplitOptions.RemoveEmptyEntries).ToList();

            var reg = new Regex(@"\b[A-Za-z]\w{2,24}\b");

            int sum = 0;
            int maxSum = int.MinValue;

            var list = new List<string>();

            for (int i = 0; i < input.Count; i++)
            {

                if (reg.IsMatch(input[i]))
                {
                    list.Add(input[i]);
                }
            }

            var res = "";

            for (int i = 0; i < list.Count - 1; i++)
            {
                sum = list[i].Length + list[i + 1].Length;

                if (maxSum < sum)
                {
                    maxSum = sum;
                    res = list[i] + "\r\n" + list[i + 1];
                }
            }

            Console.WriteLine(res);
        }
    }
}

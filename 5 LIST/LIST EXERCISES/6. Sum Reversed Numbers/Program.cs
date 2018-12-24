using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._Sum_Reversed_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ').ToList();
            int result = 0;
            string abc = null;
            for (int i = 0; i < input.Count; i++)
            {
                var res = input[i].Replace(" ", " ").Reverse();
                foreach (var x in res)
                {
                    abc += x.ToString();
                }

                result += int.Parse(abc);

                abc = null;
            }
            Console.WriteLine(result);
        }
    }
}

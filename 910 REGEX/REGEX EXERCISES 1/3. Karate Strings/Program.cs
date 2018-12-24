using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Karate_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split('>').ToList();
            int num = 0;

            for (int i = 1; i < input.Count; i++)
            {

                if (int.Parse(input[i][0].ToString()) + num <= input[i].Length)
                {
                    input[i] = input[i].Remove(0, (int.Parse(input[i][0].ToString()) + num));
                    num = 0;
                }

                else
                {              
                    num = (int.Parse(input[i][0].ToString()) + num) - input[i].Length;
                    input[i] = input[i].Remove(0, 1);
                }
            }

            Console.WriteLine(string.Join(">", input));
        }
    }
}

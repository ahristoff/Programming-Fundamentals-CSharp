using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_4.Character_Multiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ').ToList();

            var name1 = input[0];
            var name2 = input[1];

            var result1 = 0;

            for (int i = 0; i < Math.Min(name1.Length,name2.Length); i++)
            {
                result1 += (int)name1[i] * (int)name2[i];
            }

            var result2 = 0;
            
            if (name1.Length>name2.Length)
            {
                for (int i = name2.Length; i < name1.Length; i++)
                {
                    result2 += (int)name1[i];
                }
            }

            var result3 = 0;

            if (name2.Length > name1.Length)
            {
                for (int i = name1.Length; i < name2.Length ; i++)
                {
                    result3 += (int)name2[i];
                }
            }

            var output = result1 + result2 + result3;

            Console.WriteLine(output);
        }
    }
}

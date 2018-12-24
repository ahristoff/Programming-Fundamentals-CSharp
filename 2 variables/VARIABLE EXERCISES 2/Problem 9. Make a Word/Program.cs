using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_9.Make_a_Word
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string word = null;

            for (int i = 0; i < n; i++)
            {

                char characters = char.Parse(Console.ReadLine());

                word += characters;
            }

            Console.WriteLine("The word is: {0}", word);
        }
    }
}

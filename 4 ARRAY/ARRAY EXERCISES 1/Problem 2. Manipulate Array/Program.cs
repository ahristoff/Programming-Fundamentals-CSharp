using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_2.Manipulate_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine().Split(' ').ToArray();

            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var comand = Console.ReadLine().Split(' ');

                if (comand[0] == "Reverse")
                {
                    arr = arr.Reverse().ToArray();
                }

                if (comand[0] == "Distinct")
                {
                    arr = arr.Distinct().ToArray();
                }

                if (comand[0] == "Replace")
                {
                    arr[int.Parse(comand[1])] = comand[2];                    
                }
            }

            Console.WriteLine(string.Join(", ", arr));
        }
    }
}

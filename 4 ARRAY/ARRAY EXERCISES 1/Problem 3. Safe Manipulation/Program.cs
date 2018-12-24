using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_3.Safe_Manipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine().Split(' ').ToArray();

            var com = Console.ReadLine();

            while (com != "END")
            {

                var comand = com.Split(' ');

                if (comand[0] != "Reverse" && comand[0] != "Replace" && comand[0] != "Distinct")
                {
                    Console.WriteLine("Invalid input!");
                }

                else if (comand[0] == "Reverse")
                {
                    arr = arr.Reverse().ToArray();
                }

                else if (comand[0] == "Replace")
                {

                    if (int.Parse(comand[1]) < 0 || int.Parse(comand[1]) >= arr.Length)
                    {
                        Console.WriteLine("Invalid input!");
                    }

                    else
                    {
                        arr[int.Parse(comand[1])] = comand[2];
                    }
                }

                else if (comand[0] == "Distinct")
                {                  
                    arr = arr.Distinct().ToArray();                   
                } 

                com = Console.ReadLine();
            }

            Console.WriteLine(string.Join(", ", arr));
        }
    }
}


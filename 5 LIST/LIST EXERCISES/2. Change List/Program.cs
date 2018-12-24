using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._Change_List
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = Console.ReadLine().Split().Select(int.Parse).ToList();
            var comand = Console.ReadLine();

            var res = new List<int>();

            while (comand != "Odd" && comand != "Even")
            {
                var com = comand.Split();

                if (com[0] == "Delete")
                {
                    list = list.Where(w => w != int.Parse(com[1])).ToList();
                }

                else if (com[0] == "Insert")
                {
                    list.Insert(int.Parse(com[2]), int.Parse(com[1]));
                }

                comand = Console.ReadLine();
            }

            if (comand == "Odd")
            {
                list = list.Where(w => w % 2 == 1).ToList();
            }

            else if (comand == "Even")
            {
                list = list.Where(w => w % 2 == 0).ToList();
            }

            Console.WriteLine(string.Join(" ", list));
        }
    }
}

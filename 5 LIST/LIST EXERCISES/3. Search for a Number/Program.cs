using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._Search_for_a_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var arr = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            var lenght = arr[0];
            var delete = arr[1];
            var matchNum = arr[2];

            var res = list.Take(lenght).Skip(delete).Contains(matchNum);

            if (res == true)
            {
                Console.WriteLine("YES!");
            }

            else
            {
                Console.WriteLine("NO!");
            }
        }
    }
}

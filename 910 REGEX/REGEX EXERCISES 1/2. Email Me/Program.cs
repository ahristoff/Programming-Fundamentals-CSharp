using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Email_Me
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split('@').ToList();

            int left = 0;

            for (int i = 0; i < input[0].Length; i++)
            {
                left += (int)input[0][i];
            }
           
            int right = 0;

            for (int i = 0; i < input[1].Length; i++)
            {
                right += (int)input[1][i];
            }
            
            if (left - right >= 0)
            {
                Console.WriteLine("Call her!");
            }

            else if (left -right <0)
            {
                Console.WriteLine("She is not the one.");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_1.X
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int s1 = 0;
            int s2 = n - 2;

            for (int i = 1; i <= n / 2; i++)
            {
                Console.WriteLine("{0}x{1}x", new string(' ', s1), new string(' ', s2));
                s1++;
                s2 -= 2;
            }

            int s3 = n / 2;

            Console.WriteLine("{0}x", new string(' ', s3));

            int s4 = (n / 2) - 1;
            int s5 = 1;

            for (int i = 1; i <= n / 2; i++)
            {
                Console.WriteLine("{0}x{1}x", new string(' ', s4), new string(' ', s5));
                s4--;
                s5 += 2;
            }
        }
    }
}

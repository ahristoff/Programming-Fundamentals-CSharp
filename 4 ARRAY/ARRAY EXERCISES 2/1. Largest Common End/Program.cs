using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Largest_Common_End
{
    class Program
    {
        static void Main(string[] args)
        {            
            string[] a = Console.ReadLine().Split(' ');
            string[] b = Console.ReadLine().Split(' ');

            int counterInFront = 0;
            int counterFromBehind = 0;

            for (int i = 0; i < Math.Min(a.Length,b.Length); i++)
            {
                if (a[i]==b[i])
                {
                    counterInFront++;
                }

                else
                {
                    break;
                }
            }

            string[] aReversed = a.Reverse().ToArray();
            string[] bReversed = b.Reverse().ToArray();

            for (int i = 0; i < Math.Min(aReversed.Length, bReversed.Length); i++)
            {
                if (aReversed[i] == bReversed[i])
                {
                    counterFromBehind++;
                }
                else
                {
                    break;
                }
            }

            if (counterInFront >= counterFromBehind)
            {
                Console.WriteLine(counterInFront);
            }

            else
            {
                Console.WriteLine(counterFromBehind);
            }
        }
    }
}

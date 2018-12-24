using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_5.BPM_Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());
            double m = double.Parse(Console.ReadLine());

            double bars = ((n/4) * m) / n;
            double time = Math.Floor((60 * m) / n);

            Console.WriteLine("{0} bars - {1}m {2}s", Math.Round(bars, 1), (int)(time / 60),time % 60);
        }
    }
}

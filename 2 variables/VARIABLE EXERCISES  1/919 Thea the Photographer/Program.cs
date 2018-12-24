using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _919_Thea_the_Photographer
{
    class Program
    {
        static void Main(string[] args)
        {
            long N =  long.Parse(Console.ReadLine());
            long FT = long.Parse(Console.ReadLine());
            long FF = long.Parse(Console.ReadLine());
            long UT = long.Parse(Console.ReadLine());

            long timeFilter = N * FT;
            double uploudPic = Math.Ceiling(N*((double)FF /100));
            long totalTime = timeFilter + (long)uploudPic * UT;

            long d = (long)(totalTime / 86400);
            long h = (long)((totalTime - d * 86400) / 3600);
            long m = (long)((totalTime - d * 86400 - h * 3600) / 60);
            long s = (long)(totalTime - d * 86400 - h * 3600 - m * 60);
          
            Console.WriteLine("{0}:{1:00}:{2:00}:{3:00}", d, h, m, s);
        }
    }
}

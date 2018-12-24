using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_4.Photo_Gallery
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberFoto = int.Parse(Console.ReadLine());
            int day = int.Parse(Console.ReadLine());
            int month = int.Parse(Console.ReadLine());
            int year = int.Parse(Console.ReadLine());
            int hour = int.Parse(Console.ReadLine());
            int min = int.Parse(Console.ReadLine());
            int size = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());

            Console.WriteLine("Name: DSC_{0:d4}.jpg",numberFoto);
            Console.WriteLine("Date Taken: {0:d2}/{1:d2}/{2} {3:d2}:{4:d2}",day,month,year,hour,min);

            if (size<1000)
            {
                Console.WriteLine("Size: {0}B",size);
            }

            else if (size>=1000 && size<1000000)
            {
                Console.WriteLine("Size: {0}KB", size/1000.0);
            }

            else if (size>=1000000)
            {
                Console.WriteLine("Size: {0}MB", size / 1000000.0);
            }

            if (width> height)
            {
                Console.WriteLine("Resolution: {0}x{1} (landscape)",width,height);
            }

            else if (width < height)
            {
                Console.WriteLine("Resolution: {0}x{1} (portrait)", width, height);
            }

            else if (width == height)
            {
                Console.WriteLine("Resolution: {0}x{1} (square)", width, height);
            }                  
        }
    }
}

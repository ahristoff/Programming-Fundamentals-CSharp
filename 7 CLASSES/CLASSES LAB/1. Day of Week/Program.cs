using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace _1.Day_of_Week
{
    class Program
    {
        static void Main(string[] args)
        {
            string date = Console.ReadLine();

            var currDate = new DateTime();
            currDate = DateTime.ParseExact(date,"d-M-yyyy", CultureInfo.InvariantCulture);

            Console.WriteLine(currDate.DayOfWeek);
        }
    }
}

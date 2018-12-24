using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace _1.Count_Working_Days
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstDate = Console.ReadLine();
            string secondDate = Console.ReadLine();

            var startDate = DateTime.ParseExact(firstDate, "d-MM-yyyy", CultureInfo.InvariantCulture);          
            var endDate = DateTime.ParseExact(secondDate, "d-MM-yyyy", CultureInfo.InvariantCulture);

            DateTime[] freeDays = new DateTime[11];

            freeDays[0] = new DateTime(endDate.Year, 1, 1);
            freeDays[1] = new DateTime(endDate.Year, 3, 3);
            freeDays[2] = new DateTime(endDate.Year, 5, 1);
            freeDays[3] = new DateTime(endDate.Year, 5, 6);
            freeDays[4] = new DateTime(endDate.Year, 5, 24);
            freeDays[5] = new DateTime(endDate.Year, 9, 6);
            freeDays[6] = new DateTime(endDate.Year, 9, 22);
            freeDays[7] = new DateTime(endDate.Year, 11, 1);
            freeDays[8] = new DateTime(endDate.Year, 12, 24);
            freeDays[9] = new DateTime(endDate.Year, 12, 25);
            freeDays[10] = new DateTime(endDate.Year, 12, 26);


            var workingDays = endDate.Subtract(startDate);

            var holidays = new DateTime();
            
            for (var i = startDate; i <= endDate; i = i.AddDays(1))
            {
                var day = i.DayOfWeek;

                if (freeDays.Contains(i) || day.Equals(DayOfWeek.Saturday) || day.Equals(DayOfWeek.Sunday))
                {
                   holidays = holidays.AddDays(1);
                }
            }

            Console.WriteLine(((int)workingDays.Days + 1) - ((int)holidays.Day-1));     
        }
    }
}


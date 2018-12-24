using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_1.SoftUni_Coffee_Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            decimal res = 0M;
            decimal totalPrice = 0M;

            for (int i = 0; i < n; i++)
            {
                decimal pricePerCapsule = decimal.Parse(Console.ReadLine());
                string date = Console.ReadLine();
                long capsules = long.Parse(Console.ReadLine());

                var days = date.Split('/').ToList();
                int daysInMonth = DateTime.DaysInMonth(int.Parse(days[2]), int.Parse(days[1]));

                res = pricePerCapsule * capsules * daysInMonth;

                Console.WriteLine("The price for the coffee is: ${0:f2}", res);

                totalPrice += res;
                res = 0;
            }

            Console.WriteLine("Total: ${0:f2}", totalPrice);
        }
    }
}

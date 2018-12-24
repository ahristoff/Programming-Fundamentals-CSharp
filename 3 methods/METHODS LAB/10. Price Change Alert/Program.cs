using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Price_Change_Alert
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double limit = double.Parse(Console.ReadLine());
            double lastPrice = double.Parse(Console.ReadLine());

            for (int i = 0; i < n - 1; i++)
            {
                double newPrice = double.Parse(Console.ReadLine());

                double div = Proc(lastPrice, newPrice);
                bool significantDifference = Diff(div, limit);
                string message = ShowResult(newPrice, lastPrice, div, significantDifference);

                Console.WriteLine(message);

                lastPrice = newPrice;
            }
        }

        private static string ShowResult(double newPrice, double lastPrice, double difference, bool etherTrueOrFalse)
        {
            string res = "";

            if (difference == 0)
            {
                res = string.Format("NO CHANGE: {0}", newPrice);
            }

            else if (!etherTrueOrFalse)
            {
                res = string.Format("MINOR CHANGE: {0} to {1} ({2:f2}%)", lastPrice, newPrice, difference * 100);
            }

            else if (etherTrueOrFalse && (difference > 0))
            {
                res = string.Format("PRICE UP: {0} to {1} ({2:f2}%)", lastPrice, newPrice, difference * 100);
            }

            else if (etherTrueOrFalse && (difference < 0))
                res = string.Format("PRICE DOWN: {0} to {1} ({2:f2}%)", lastPrice, newPrice, difference * 100);

            return res;
        }

        private static bool Diff(double limit, double isDiff)
        {

            if (Math.Abs(limit) >= isDiff)
            {
                return true;
            }

            return false;
        }

        private static double Proc(double l, double newPrice)
        {
            double r = (newPrice - l) / l;
            return r;
        }
    }
}


using System;

namespace Problem_4._Hotel
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());

            if (month == "May")
            {

                if (n > 0 && n <= 7)
                {

                    Console.WriteLine("Studio: {0:f2} lv.", n * 50);
                    Console.WriteLine("Double: {0:f2} lv.", n * 65);
                    Console.WriteLine("Suite: {0:f2} lv.", n * 75);
                }

                else if (n > 7)
                {
                    Console.WriteLine("Studio: {0:f2} lv.", (n * 50) - (n * 50) * 0.05);
                    Console.WriteLine("Double: {0:f2} lv.", n * 65);
                    Console.WriteLine("Suite: {0:f2} lv.", n * 75);
                }
            }

            else if (month == "October")
            {

                if (n > 0 && n <= 7)
                {

                    Console.WriteLine("Studio: {0:f2} lv.", n * 50);
                    Console.WriteLine("Double: {0:f2} lv.", n * 65);
                    Console.WriteLine("Suite: {0:f2} lv.", n * 75);
                }

                else if (n > 7)
                {

                    Console.WriteLine("Studio: {0:f2} lv.", (((n * 50) - (n * 50 * 0.05)) - ((n * 50) - (n * 50 * 0.05)) / n));
                    Console.WriteLine("Double: {0:f2} lv.", n * 65);
                    Console.WriteLine("Suite: {0:f2} lv.", n * 75);
                }
            }

            else if (month == "June")
            {

                if (n > 0 && n <= 14)
                {

                    Console.WriteLine("Studio: {0:f2} lv.", n * 60);
                    Console.WriteLine("Double: {0:f2} lv.", n * 72);
                    Console.WriteLine("Suite: {0:f2} lv.", n * 82);
                }

                else if (n > 14)
                {

                    Console.WriteLine("Studio: {0:f2} lv.", n * 60);
                    Console.WriteLine("Double: {0:f2} lv.", (n * 72) - (n * 72 * 0.1));
                    Console.WriteLine("Suite: {0:f2} lv.", n * 82);
                }
            }

            else if (month == "September")
            {

                if (n > 0 && n <= 7)
                {

                    Console.WriteLine("Studio: {0:f2} lv.", n * 60);
                    Console.WriteLine("Double: {0:f2} lv.", n * 72);
                    Console.WriteLine("Suite: {0:f2} lv.", n * 82);
                }

                else if (n > 7 && n <= 14)
                {

                    Console.WriteLine("Studio: {0:f2} lv.", ((n - 1) * 60));
                    Console.WriteLine("Double: {0:f2} lv.", n * 72);
                    Console.WriteLine("Suite: {0:f2} lv.", n * 82);
                }

                else if (n > 14)
                {

                    Console.WriteLine("Studio: {0:f2} lv.", (n - 1) * 60);
                    Console.WriteLine("Double: {0:f2} lv.", (n * 72) - (n * 72 * 0.1));
                    Console.WriteLine("Suite: {0:f2} lv.", n * 82);
                }
            }
            else if (month == "July" || month == "August" || month == "December")
            {

                if (n > 0 && n <= 14)
                {

                    Console.WriteLine("Studio: {0:f2} lv.", n * 68);
                    Console.WriteLine("Double: {0:f2} lv.", n * 77);
                    Console.WriteLine("Suite: {0:f2} lv.", n * 89);
                }

                else if (n > 14)
                {

                    Console.WriteLine("Studio: {0:f2} lv.", n * 68);
                    Console.WriteLine("Double: {0:f2} lv.", n * 77);
                    Console.WriteLine("Suite: {0:f2} lv.", (n * 89) - (n * 89 * 0.15));
                }
            }
        }
    }
}

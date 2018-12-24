using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_3.Restaurant_Discount
{
    class Program
    {
        static void Main(string[] args)
        {
            int gast = int.Parse(Console.ReadLine());
            string package = Console.ReadLine();

            if (gast>0&&gast<=50)
            {

                if (package == "Normal")
                {

                    Console.WriteLine("We can offer you the Small Hall");
                    Console.WriteLine("The price per person is {0:f2}$",(3000-(3000*0.05))/gast);
                }

                else if (package == "Gold")
                {

                    Console.WriteLine("We can offer you the Small Hall");
                    Console.WriteLine("The price per person is {0:f2}$", (3250-(3250 * 0.1)) / gast);
                }

                else if (package == "Platinum")
                {
                    Console.WriteLine("We can offer you the Small Hall");
                    Console.WriteLine("The price per person is {0:f2}$", (3500-(3500 * 0.15)) / gast);
                }
            }

            else if (gast > 50 && gast <= 100)
            {

                if (package == "Normal")
                {

                    Console.WriteLine("We can offer you the Terrace");
                    Console.WriteLine("The price per person is {0:f2}$", (5500 - (5500 * 0.05)) / gast);
                }

                else if (package == "Gold")
                {

                    Console.WriteLine("We can offer you the Terrace");
                    Console.WriteLine("The price per person is {0:f2}$", (5750 - (5750 * 0.1)) / gast);
                }

                else if (package == "Platinum")
                {

                    Console.WriteLine("We can offer you the Terrace");
                    Console.WriteLine("The price per person is {0:f2}$", (6000 - (6000 * 0.15)) / gast);
                }
            }

            else if (gast > 100 && gast <= 120)
            {

                if (package == "Normal")
                {

                    Console.WriteLine("We can offer you the Great Hall");
                    Console.WriteLine("The price per person is {0:f2}$", (8000 - (8000 * 0.05)) / gast);
                }

                else if (package == "Gold")
                {

                    Console.WriteLine("We can offer you the Great Hall");
                    Console.WriteLine("The price per person is {0:f2}$", (8250 - (8250 * 0.1)) / gast);
                }

                else if (package == "Platinum")
                {

                    Console.WriteLine("We can offer you the Great Hall");
                    Console.WriteLine("The price per person is {0:f2}$", (8500 - (8500 * 0.15)) / gast);
                }
            }

            else
            {
                Console.WriteLine("We do not have an appropriate hall.");
            }
        }
    }
}

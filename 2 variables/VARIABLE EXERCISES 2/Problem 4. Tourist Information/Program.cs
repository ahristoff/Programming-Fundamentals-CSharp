using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_4.Tourist_Information
{
    class Program
    {
        static void Main(string[] args)
        {
            string units = Console.ReadLine();
            double num = double.Parse(Console.ReadLine());

            if (units == "miles")
            {
                Console.WriteLine("{0} miles = {1:f2} kilometers", num, num*1.6);
            }

            else if (units == "inches")
            {
                Console.WriteLine("{0} inches = {1:f2} centimeters", num, num * 2.54);
            }

            else if (units == "feet")
            {
                Console.WriteLine("{0} feet = {1:f2} centimeters", num, num * 30);
            }

            else if (units == "yards")
            {
                Console.WriteLine("{0} yards = {1:f2} meters", num , num * 0.91);
            }

            else if (units == "gallons")
            {
                Console.WriteLine("{0} gallons = {1:f2} liters", num, num * 3.8);
            }
        }
    }
}

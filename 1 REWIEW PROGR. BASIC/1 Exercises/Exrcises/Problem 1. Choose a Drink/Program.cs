using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_1.Choose_a_Drink
{
    class Program
    {
        static void Main(string[] args)
        {
            string prof = Console.ReadLine();

            if (prof == "Athlete")
            {
                Console.WriteLine("Water");
            }

            else if (prof == "Businessman" || prof== "Businesswoman")
            {
                Console.WriteLine("Coffee");
            }

            else if (prof == "SoftUni Student")
            {
                Console.WriteLine("Beer");
            }

            else
            {
                Console.WriteLine("Tea");
            }
        }
    }
}

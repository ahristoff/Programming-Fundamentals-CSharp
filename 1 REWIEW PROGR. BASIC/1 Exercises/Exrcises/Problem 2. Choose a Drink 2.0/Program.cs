using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_2.Choose_a_Drink_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            string prof = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());

            if (prof == "Athlete")
            {
                Console.WriteLine("The {0} has to pay {1:f2}.", prof, 0.70 * quantity);
            }

            else if (prof == "Businessman" || prof == "Businesswoman")
            {
                Console.WriteLine("The {0} has to pay {1:f2}.", prof, 1.00 * quantity);
            }

            else if (prof == "SoftUni Student")
            {
                Console.WriteLine("The {0} has to pay {1:f2}.", prof, 1.70 * quantity);
            }

            else
            {
                Console.WriteLine("The {0} has to pay {1:f2}.", prof, 1.2 * quantity);
            }
        }
    }
}

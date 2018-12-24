using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_7.Training_Hall_Equipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());

            double sum = 0;

            for (int i = 1; i <= n; i++)
            {

                string name = Console.ReadLine();
                double prise = double.Parse(Console.ReadLine());
                int quantity = int.Parse(Console.ReadLine());

                if (quantity == 1)
                {
                    Console.WriteLine("Adding {0} {1} to cart.", quantity, name);
                }

                else if (quantity > 1)
                {
                    Console.WriteLine("Adding {0} {1} to cart.", quantity, name+'s');
                }
                
                sum += quantity * prise;
            }

            Console.WriteLine("Subtotal: ${0:f2}",sum);

            if (budget-sum > 0)
            {
                Console.WriteLine("Money left: ${0:f2}", budget - sum);
            }

            else
            {
                Console.WriteLine("Not enough. We need ${0:f2} more.",sum-budget);
            }       
        }
    }
}

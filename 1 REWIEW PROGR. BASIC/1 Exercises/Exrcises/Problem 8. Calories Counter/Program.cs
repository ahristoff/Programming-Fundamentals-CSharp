using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_8.Calories_Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var caloriesCount = 0;

            for (int i = 0; i < n; i++)
            {
                string ingredients = Console.ReadLine();

                if (ingredients.ToLower() == "cheese")
                {
                    caloriesCount += 500;
                }

                else if (ingredients.ToLower() == "tomato sauce")
                {
                    caloriesCount += 150;
                }

                else if (ingredients.ToLower() == "salami")
                {
                    caloriesCount += 600;
                }

                else if (ingredients.ToLower() == "pepper")
                {
                    caloriesCount += 50;
                }
            }

            Console.WriteLine("Total calories: {0}",caloriesCount);
        }
    }
}

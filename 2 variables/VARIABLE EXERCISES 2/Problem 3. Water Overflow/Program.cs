using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_3.Water_Overflow
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int capacity = 0;

            for (int i = 0; i < n; i++)
            {

                int quantitiesOfWater = int.Parse(Console.ReadLine());

                if (capacity + quantitiesOfWater <= 255)
                {
                    capacity += quantitiesOfWater;               
                }

                else if (capacity + quantitiesOfWater > 255)
                {
                    Console.WriteLine("Insufficient capacity!");
                }                
            }

            Console.WriteLine(capacity);
        }
    }
}

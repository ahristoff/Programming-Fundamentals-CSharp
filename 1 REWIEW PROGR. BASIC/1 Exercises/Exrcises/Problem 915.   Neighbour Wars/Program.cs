using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_915.Neighbour_Wars
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());

            int n1 = 100;
            int m1 = 100;
            int roundCount = 0;

            while (true)
            {

                roundCount++;
                
                if (roundCount % 2 == 1)
                {
                    
                    n1 = n1 - n;
                   
                    if (n1 <= 0)
                    {

                        Console.WriteLine("Pesho won in {0}th round.", roundCount);
                        break;
                    }

                    Console.WriteLine("Pesho used Roundhouse kick and reduced Gosho to {0} health.",n1);
                }

                if (roundCount % 3 == 0)
                {
                    n1 = n1 + 10;
                }
                
                if (roundCount % 2 == 0)
                {
                   
                    m1 = m1 - m;
                    
                    if (m1 <= 0)
                    {

                        Console.WriteLine("Gosho won in {0}th round.", roundCount);
                        break;
                    }

                    Console.WriteLine("Gosho used Thunderous fist and reduced Pesho to {0} health.",m1);          
                }

                if (roundCount % 3 == 0)
                {
                    m1 = m1 + 10;
                }
            }
        }
    }
}

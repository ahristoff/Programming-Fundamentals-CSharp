using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_3.Immune_System
{
    class Program
    {
        static void Main(string[] args)
        {
            var dict = new Dictionary<string, int>();

            int initialHealth  = int.Parse(Console.ReadLine());        
            string com = Console.ReadLine();

            while (initialHealth  > 0 && com != "end")
            {
                int nSubstitute = initialHealth ;
               
                if (!dict.ContainsKey(com))
                {                    
                    int sum = 0;

                    for (int i = 0; i < com.Length; i++)
                    {
                        sum += (int)(com[i]);
                    }

                    int allsum = sum / 3;
                    dict[com] = allsum * com.Length;

                    Console.WriteLine("Virus {0}: {1} => {2} seconds", com, allsum, dict[com]);

                    initialHealth  = initialHealth  - dict[com];
                    initialHealth  = initialHealth  + (20 * initialHealth ) / 100;

                    if (initialHealth  > nSubstitute)
                    {
                        initialHealth  = nSubstitute;
                    }

                    if (initialHealth  <= 0)
                    {
                        Console.WriteLine("Immune System Defeated.");
                        break;
                    }

                    Console.WriteLine("{0} defeated in {1}m {2}s.", com, dict[com] / 60, dict[com] % 60);
                    Console.WriteLine("Remaining health: {0}", nSubstitute - dict[com]);                   
                }

                else
                {
                    int sum = 0;

                    for (int i = 0; i < com.Length; i++)
                    {
                        sum += (int)(com[i]);
                    }

                    int allsum = sum / 3;
                    dict[com] = allsum * com.Length / 3;

                    Console.WriteLine("Virus {0}: {1} => {2} seconds", com, allsum, dict[com]);

                    initialHealth  = initialHealth  - dict[com];
                    initialHealth  = initialHealth  + (20 * initialHealth ) / 100;

                    if (initialHealth  > nSubstitute)
                    {
                        initialHealth  = nSubstitute;
                    }

                    if (initialHealth  <= 0)
                    {
                        Console.WriteLine("Immune System Defeated.");
                        break;
                    }

                    Console.WriteLine("{0} defeated in {1}m {2}s.", com, dict[com] / 60, dict[com] % 60);
                    Console.WriteLine("Remaining health: {0}", nSubstitute - dict[com]);                  
                }

                com = Console.ReadLine();
            }

            if (initialHealth  > 0)
            {
                Console.WriteLine("Final Health: {0}", initialHealth);
            }           
        }
    }
}

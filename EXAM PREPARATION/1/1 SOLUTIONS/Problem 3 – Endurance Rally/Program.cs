using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_3___Endurance_Rally
{
    class Program
    {
        static void Main(string[] args)
        {
            var names = Console.ReadLine().Split(' ').ToList();
            var zones = Console.ReadLine().Split(' ').Select(decimal.Parse).ToList();
            var checkpoinnts = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            for (int i = 0; i < names.Count; i++)
            {

                bool insufficientQuantityFuel = false;
                decimal fuel = names[i][0];

                for (int i1 = 0; i1 < zones.Count; i1++)
                {
                    int count = 0;

                    for (int i2 = 0; i2 < checkpoinnts.Count; i2++)
                    {
                        if (i1 == checkpoinnts[i2])
                        {
                            fuel = fuel + zones[i1];
                            break;
                        }

                        else
                        {
                            count++;
                        }

                        if (count == checkpoinnts.Count)
                        {
                            fuel = fuel - zones[i1];
                        }
                    }

                    if (fuel <= 0)
                    {
                        Console.WriteLine("{0} - reached {1}", names[i], i1);

                        insufficientQuantityFuel = true;
                        break;
                    }
                }

                if (insufficientQuantityFuel == false)
                {
                    Console.WriteLine("{0} - fuel left {1:f2}", names[i], fuel);
                }
            }
        }
    }
}


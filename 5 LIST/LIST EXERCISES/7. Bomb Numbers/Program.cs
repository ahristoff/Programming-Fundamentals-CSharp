using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._Bomb_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> num = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> bomb = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            int a = 0;
            long sum = 0;

            for (int i = 0; i < bomb.Count - 1; i++)
            {

                for (int j = 0; j < num.Count; j++)
                {

                    if (bomb[0] == num[j])
                    {
                        a = 1;

                        if (j - bomb[1] < 0 && j + bomb[1] < num.Count)
                        {
                            num.RemoveRange(0, j + bomb[1] + 1);
                        }

                        else if (j - bomb[1] >= 0 && j + bomb[1] >= num.Count)
                        {
                            num.RemoveRange(j - bomb[1], num.Count - (j - (bomb[1])));
                        }

                        else if (j - bomb[1] < 0 && j + bomb[1] >= num.Count)
                        {
                            num.RemoveRange(0, num.Count);
                        }

                        else
                        {
                            num.RemoveRange(j - bomb[1], 2 * bomb[1] + 1);
                        }
                    }
                }
            }

            if (a == 1)
            {

                for (int i = 0; i < num.Count; i++)
                {
                    sum += num[i];
                }
            }

            else
            {
                sum = num.Sum();
            }

            Console.WriteLine(sum);
        }
    }
}

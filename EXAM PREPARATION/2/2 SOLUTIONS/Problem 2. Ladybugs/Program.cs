using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_2.Ladybugs
{
    class Program
    {
        static void Main(string[] args)
        {
            var size = long.Parse(Console.ReadLine());
            var inputIndex = Console.ReadLine().Split().Select(int.Parse).ToList();

            var initialField = new List<long>();

            for (int i = 0; i < size; i++)
            {
                initialField.Add(0);
            }

            for (int i = 0; i < inputIndex.Count; i++)
            {
                if (inputIndex[i] < size && inputIndex[i] >= 0)
                {
                    initialField[inputIndex[i]] = 1;
                }

            }

            //Console.WriteLine(string.Join(" ", initialField));

            var comand = Console.ReadLine();

            while (comand != "end")
            {
                var com = comand.Split().ToList();

                var startSize = int.Parse(com[0]);
                var comm = com[1];
                var step = int.Parse(com[2]);

                if (startSize >= initialField.Count || startSize < 0)
                {
                    comand = Console.ReadLine();
                    continue;
                }

                if (initialField[startSize] == 0)
                {
                    comand = Console.ReadLine();
                    continue;
                }

                if (comm == "right")
                {
                    initialField[startSize] = 0;
                    while (true)
                    {
                        startSize += step;

                        if (startSize < 0 || startSize >= initialField.Count)
                        {
                            break;
                        }

                        if (initialField[startSize] == 1)
                        {                            
                            continue;
                        }

                        if (initialField[startSize] == 0)
                        {
                            initialField[startSize] = 1;
                            break;
                        }
                    }
                }

                if (comm == "left")
                {
                    initialField[startSize] = 0;

                    while (true)
                    {
                        startSize -= step;

                        if (startSize < 0 || startSize >= initialField.Count)
                        {
                           
                            break;
                        }

                        if (initialField[startSize] == 1)
                        {                      
                            continue;
                        }

                        if (initialField[startSize] == 0)
                        {
                            initialField[startSize] = 1;
                            break;
                        }
                    }
                }

                comand = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", initialField));
        }
    }
}

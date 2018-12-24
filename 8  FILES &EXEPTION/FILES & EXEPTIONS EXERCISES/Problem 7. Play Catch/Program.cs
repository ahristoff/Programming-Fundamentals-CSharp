using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_7.Play_Catch
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            int countExeption = 0;

            while (countExeption < 3)
            {
                var com = Console.ReadLine().Split(' ').ToList();

                if (com[0] == "Replace")
                {
                    try
                    {
                        input.RemoveAt(int.Parse(com[1]));
                        input.Insert(int.Parse(com[1]), int.Parse(com[2]));
                    }
                    catch (ArgumentOutOfRangeException)
                    {
                        Console.WriteLine("The index does not exist!");
                        countExeption++;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("The variable is not in the correct format!");
                        countExeption++;
                    }
                }

                if (com[0] == "Show")
                {
                    try
                    {
                        int show = input[int.Parse(com[1])];
                        Console.WriteLine(show);
                       
                    }
                    catch (ArgumentOutOfRangeException)
                    {
                        Console.WriteLine("The index does not exist!");
                        countExeption++;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("The variable is not in the correct format!");
                        countExeption++;
                    }
                }

                if (com[0] == "Print")
                {
                    var print = new List<int>();

                    try
                    {
                        for (int i = int.Parse(com[1]); i <= int.Parse(com[2]); i++)
                        {
                            print.Add(input[i]);                                                     
                        }

                        Console.WriteLine(string.Join(", ", print));
                    }

                    catch (ArgumentOutOfRangeException)
                    {
                        Console.WriteLine("The index does not exist!");
                        countExeption++;
                    }

                    catch (FormatException)
                    {
                        Console.WriteLine("The variable is not in the correct format!");
                        countExeption++;
                    }
                }
            }

            Console.WriteLine(string.Join(", ",input));
        }
    }
}

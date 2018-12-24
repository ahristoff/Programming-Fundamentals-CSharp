using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_8._SMS_Typing
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var listLetter = new List<char>();
            var listDigit = new List<char>();
 
            for (var j = 'a'; j <= 'z'; j++)
            {
                listLetter.Add(j);
            }

            listLetter.Insert(0, ' ');

            for (int i = 1; i <= n; i++)
            {

                var m = Console.ReadLine();

                int x = 0;
                int y = 0;
                listDigit.Clear();

                foreach (var p in m)
                {
                    listDigit.Add(p);
                }

                x = listDigit[0]-48;
                y = listDigit.Count;
              
                if (x == 0)
                {
                    Console.Write(" ");
                }

                else if (x == 2)
                {

                    if ( y == 1)
                    {
                        Console.Write("a");
                    }

                    if (y == 2)
                    {
                        Console.Write("b");
                    }

                    if (y == 3)
                    {
                        Console.Write("c");
                    }
                }

                else if (x == 3)
                {
                    if (y == 1)
                    {
                        Console.Write("d");
                    }

                    if (y == 2)
                    {
                        Console.Write("e");
                    }

                    if (y == 3)
                    {
                        Console.Write("f");
                    }
                }

                else if (x == 4)
                {

                    if (y == 1)
                    {
                        Console.Write("g");
                    }

                    if (y == 2)
                    {
                        Console.Write("h");
                    }

                    if (y == 3)
                    {
                        Console.Write("i");
                    }
                }

                else if (x == 5)
                {
                    if (y == 1)
                    {
                        Console.Write("j");
                    }

                    if (y == 2)
                    {
                        Console.Write("k");
                    }

                    if (y == 3)
                    {
                        Console.Write("l");
                    }
                }

                else if (x == 6)
                {

                    if (y == 1)
                    {
                        Console.Write("m");
                    }

                    if (y == 2)
                    {
                        Console.Write("n");
                    }

                    if (y == 3)
                    {
                        Console.Write("o");
                    }
                }

                else if (x == 7)
                {

                    if (y == 1)
                    {
                        Console.Write("p");
                    }

                    if (y == 2)
                    {
                        Console.Write("q");
                    }

                    if (y == 3)
                    {
                        Console.Write("r");
                    }

                    if (y == 4)
                    {
                        Console.Write("s");
                    }
                }

                else if (x == 8)
                {

                    if (y == 1)
                    {
                        Console.Write("t");
                    }

                    if (y == 2)
                    {
                        Console.Write("u");
                    }

                    if (y == 3)
                    {
                        Console.Write("v");
                    }
                }

                else if (x == 9)
                {

                    if (y == 1)
                    {
                        Console.Write("w");
                    }

                    if (y == 2)
                    {
                        Console.Write("x");
                    }

                    if (y == 3)
                    {
                        Console.Write("y");
                    }

                    if (y == 4)
                    {
                        Console.Write("z");
                    }
                }               
            }
            Console.WriteLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_2___Array_Manipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = Console.ReadLine().Split(' ').Select(long.Parse).ToList();
            var comand = Console.ReadLine();

            var sb = new StringBuilder();

            while (comand != "end")
            {
                var com = comand.Split(' ').ToList();

                if (com[0] == "exchange")
                {
                    var num = int.Parse(com[1]);

                    if (num >= list.Count || num < 0)
                    {
                        sb.AppendLine("Invalid index");
                    }

                    else
                    {
                        for (int i = 0; i < num + 1 % list.Count; i++)
                        {
                            var a = list[0];

                            for (int j = 1; j < list.Count; j++)
                            {
                                list[j - 1] = list[j];
                            }

                            list[list.Count - 1] = a;
                        }
                    }
                }

                if (com[0] == "max" && com[1] == "odd")
                {

                    if (Odd(list).Count == 0)
                    {
                        sb.AppendLine("No matches");
                    }
                    else
                    {

                        for (int i = list.Count - 1; i >= 0; i--)
                        {

                            if (list[i] == Odd(list).Max())
                            {
                                sb.AppendLine(i.ToString());

                                break;
                            }
                        }
                    }
                }

                if (com[0] == "min" && com[1] == "odd")
                {

                    if (Odd(list).Count == 0)
                    {
                        sb.AppendLine("No matches");
                    }

                    else
                    {

                        for (int i = list.Count - 1; i >= 0; i--)
                        {

                            if (list[i] == Odd(list).Min())
                            {
                                sb.AppendLine(i.ToString());

                                break;
                            }
                        }
                    }
                }

                if (com[0] == "max" && com[1] == "even")
                {

                    if (Even(list).Count == 0)
                    {
                        sb.AppendLine("No matches");
                    }
                    else
                    {

                        for (int i = list.Count - 1; i >= 0; i--)
                        {

                            if (list[i] == Even(list).Max())
                            {
                                sb.AppendLine(i.ToString());

                                break;
                            }
                        }
                    }
                }

                if (com[0] == "min" && com[1] == "even")
                {

                    if (Even(list).Count == 0)
                    {
                        sb.AppendLine("No matches");
                    }

                    else
                    {

                        for (int i = list.Count - 1; i >= 0; i--)
                        {

                            if (list[i] == Even(list).Min())
                            {
                                sb.AppendLine(i.ToString());

                                break;
                            }
                        }
                    }
                }

                if (com[0] == "first" && com[2] == "odd")
                {

                    if (list.Count < int.Parse(com[1]) || int.Parse(com[1]) < 1)
                    {
                        sb.AppendLine("Invalid count");
                    }

                    else
                    {
                        var firstOdd = new List<long>();

                        for (int i = 0; i < Math.Min(int.Parse(com[1]), Odd(list).Count); i++)
                        {

                            if (Odd(list).Count > 0)
                            {
                                firstOdd.Add(Odd(list)[i]);
                            }
                        }

                        sb.AppendLine(String.Format("[{0}]", string.Join(", ", firstOdd)));
                    }
                }

                if (com[0] == "first" && com[2] == "even")
                {

                    if (list.Count < int.Parse(com[1]) || int.Parse(com[1]) < 1)
                    {
                        sb.AppendLine("Invalid count");
                    }

                    else
                    {
                        var firstEven = new List<long>();

                        for (int i = 0; i < Math.Min(int.Parse(com[1]), Even(list).Count); i++)
                        {
                            if (Even(list).Count > 0)
                            {
                                firstEven.Add(Even(list)[i]);
                            }
                        }

                        sb.AppendLine(String.Format("[{0}]", string.Join(", ", firstEven)));
                    }
                }

                if (com[0] == "last" && com[2] == "odd")
                {
                    if (list.Count < int.Parse(com[1]) || int.Parse(com[1]) < 1)
                    {
                        sb.AppendLine("Invalid count");
                    }

                    else
                    {
                        var lastOdd = new List<long>();

                        for (int i = Odd(list).Count - 1; i >= (Odd(list).Count) - Math.Min(int.Parse(com[1]), Odd(list).Count); i--)
                        {

                            if (Odd(list).Count > 0)
                            {
                                lastOdd.Add(Odd(list)[i]);
                            }
                        }
                        sb.AppendLine(String.Format("[{0}]", string.Join(", ", lastOdd)));
                    }
                }

                if (com[0] == "last" && com[2] == "even")
                {

                    if (list.Count < int.Parse(com[1]) || int.Parse(com[1]) < 1)
                    {
                        sb.AppendLine("Invalid count");
                        //Console.WriteLine("Invalid count");
                    }

                    else
                    {
                        var lastEven = new List<long>();

                        for (int i = Even(list).Count - 1; i >= (Even(list).Count) - Math.Min(int.Parse(com[1]), Even(list).Count); i--)
                        {
                            if (Even(list).Count > 0)
                            {
                                lastEven.Add(Even(list)[i]);
                            }
                        }

                        sb.AppendLine(String.Format("[{0}]", string.Join(", ", lastEven)));
                    }
                }

                comand = Console.ReadLine();
            }

            Console.WriteLine(sb.ToString().Trim());
            Console.WriteLine("[{0}]", string.Join(", ", list));
        }

        private static List<long> Even(List<long> b)
        {
            var even = new List<long>();

            for (int i = 0; i < b.Count; i++)
            {

                if (b[i] % 2 == 0)
                {
                    even.Add(b[i]);
                }
            }

            return even;
        }

        private static List<long> Odd(List<long> a)
        {
            var odd = new List<long>();

            for (int i = 0; i < a.Count; i++)
            {

                if (a[i] % 2 == 1)
                {
                    odd.Add(a[i]);
                }
            }

            return odd;
        }
    }
}

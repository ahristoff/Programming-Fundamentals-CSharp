using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._Array_Manipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            var comand = Console.ReadLine().Split(' ').ToList();

            var res = input.ToList();

            var list = new List<int>();

            while (comand[0] != "print")
            {

                if (comand[0] == "add")
                {
                    Add(list, res, comand);
                }

                if (comand[0] == "addMany")
                {
                    AddMany(list, res, comand);
                }

                if (comand[0] == "contains")
                {
                    Contains(res, comand);
                }

                if (comand[0] == "remove")
                {
                    Remove(res, comand);
                }

                if (comand[0] == "shift")
                {
                    Shift(res, comand);
                }

                if (comand[0] == "sumPairs")
                {
                    SumPairs(res);
                }

                comand = Console.ReadLine().Split(' ').ToList();
            }

            Console.WriteLine("[{0}]", string.Join(", ", res));
        }

        private static List<int> SumPairs(List<int> res)
        {
            for (int i = 0; i < res.Count - 1; i++)
            {
                for (int j = i; j < i + 1; j++)
                {
                    res[i] = res[j] + res[j + 1];
                }
                res.RemoveAt(i + 1);
            }

            return res;
        }

        private static List<int> Shift(List<int> res, List<string> comand)
        {
            var num = int.Parse(comand[1]);

            for (int i = 0; i < num % res.Count; i++)
            {
                int a = res[0];
                for (int j = 1; j < res.Count; j++)
                {
                    res[j - 1] = res[j];
                }
                res[res.Count - 1] = a;
            }

            return res;
        }

        private static List<int> Remove(List<int> res, List<string> comand)
        {
            var num = int.Parse(comand[1]);
            res.RemoveAt(num);

            return res;
        }

        private static void Contains(List<int> res, List<string> comand)
        {
            var num = int.Parse(comand[1]);
            var a = 0;

            for (int i = 0; i < res.Count; i++)
            {

                if (num == res[i])
                {
                    Console.WriteLine(i);
                    a = 1;
                    break;
                }
            }

            if (a == 0)
            {
                Console.WriteLine(-1);
            }
        }

        private static List<int> AddMany(List<int> list, List<int> res, List<string> comand)
        {

            for (int i = 1; i < comand.Count; i++)
            {
                list.Add(int.Parse(comand[i]));
            }

            for (int i = 1; i < list.Count; i++)
            {
                res.Insert(list[0], list[list.Count - i]);
            }

            list.Clear();

            return res;
        }

        private static List<int> Add(List<int> list, List<int> res, List<string> comand)
        {

            for (int i = 1; i < comand.Count; i++)
            {
                list.Add(int.Parse(comand[i]));
            }

            res.Insert(list[0], list[1]);

            list.Clear();

            return res;
        }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_4.Roli___The_Coder
{
    class Program
    {
        static void Main(string[] args)
        {
            var dictList = new Dictionary<string, List<string>>();
            var dict = new Dictionary<string, string>();

            var comand = Console.ReadLine();

            while (comand != "Time for Code")
            {
                var com = comand.Trim().Split(new[] { ' ', '\t', '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries).ToList();

                string id = com[0].Trim();
                string eventName = com[1].Trim();

                bool falseEventName = false;

                for (int i = 0; i < com[1].Length; i++)
                {

                    if (com[1][0] != '#')
                    {
                        falseEventName = true;
                        break;
                    }
                }

                if (falseEventName == true)
                {
                    comand = Console.ReadLine();
                    continue;
                }

                var actualEventName = eventName.Substring(1, eventName.Length - 1);

                if (dict.ContainsValue(id) && !dict.ContainsKey(actualEventName))
                {
                    comand = Console.ReadLine();
                    continue;
                }

                if (!dict.ContainsKey(actualEventName))
                {
                    dict[actualEventName] = id;
                }

                if (!dictList.ContainsKey(actualEventName))
                {
                    dictList[actualEventName] = new List<string>();
                }

                for (int i = 2; i < com.Count; i++)
                {
                    if (dictList[actualEventName].Contains(com[i]))
                    {
                        continue;
                    }

                    else if (!com[i].Contains('@'))
                    {
                        continue;
                    }

                    else
                    {
                        dictList[actualEventName].Add(com[i]);
                    }
                }

                dictList[actualEventName] = dictList[actualEventName].OrderBy(s => s).ToList();

                comand = Console.ReadLine();
            }

            foreach (var y in dictList.OrderByDescending(s => s.Value.Count).ThenBy(f => f.Key))
            {
                foreach (var x in dict)
                {
                    if (x.Key == y.Key)
                    {
                        Console.WriteLine("{0} - {1}", y.Key, y.Value.Count);
                        Console.WriteLine(string.Join("\n", y.Value));
                    }
                }
            }
        }
    }
}

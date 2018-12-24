using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Problem_4___Cubic_s_Messages
{
    class Program
    {
        static void Main(string[] args)
        {
            var dict = new Dictionary<string, string>();

            var comand = Console.ReadLine();

            while (comand != "Over!")
            {
                string line = comand;

                int lenghtMessage = int.Parse(Console.ReadLine());

                var mess = new Regex(@"^([0-9]+)([A-Za-z]+)([^A-Za-z]*)$");

                if (!mess.IsMatch(line))
                {
                    comand = Console.ReadLine();
                    continue;
                }

                Match match = mess.Match(line);
                string currMessage = match.Groups[2].Value;

                if (currMessage.Length != lenghtMessage)
                {
                    comand = Console.ReadLine();
                    continue;
                }

                string num = match.Groups[1].Value + match.Groups[3].Value;

                string verification = string.Empty;

                for (int i = 0; i < num.Length; i++)
                {

                    if (char.IsDigit(num[i]))
                    {

                        if (int.Parse(num[i].ToString()) <= currMessage.Length - 1)  //convert char into int
                        {
                            verification += currMessage[int.Parse(num[i].ToString())];
                        }
                        else if (int.Parse(num[i].ToString()) > currMessage.Length - 1)
                        {
                            verification += " ";
                        }
                    }
                }

                if (!dict.ContainsKey(currMessage))
                {
                    dict[currMessage] = null;
                }

                dict[currMessage] = verification;

                comand = Console.ReadLine();
            }

            foreach (var x in dict)
            {
                Console.WriteLine("{0} == {1}", x.Key, x.Value);
            }
        }
    }
}

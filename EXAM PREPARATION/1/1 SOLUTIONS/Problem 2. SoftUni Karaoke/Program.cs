using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_2.SoftUni_Karaoke
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var dict = new Dictionary<string, List<string>>();

            var participants = Console.ReadLine()
                .Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries).ToList();
            var songs = Console.ReadLine().Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries).ToList();
            var comand = Console.ReadLine();

            bool existPaticipantAndSong = false;

            while (comand != "dawn")
            {
                var com = comand.Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries).ToList();

                var name = com[0].Trim();
                var song = com[1].Trim();
                var award = com[2].Trim();

                if (!participants.Contains(name) || !songs.Contains(song))
                {
                    comand = Console.ReadLine();
                    continue;
                }

                existPaticipantAndSong = true;

                if (!dict.ContainsKey(name))
                {
                    dict[name] = new List<string>();
                }

                dict[name].Add(award);
                dict[name] = dict[name].Distinct().OrderBy(f => f).ToList();

                comand = Console.ReadLine();
            }

            if (existPaticipantAndSong == false)
            {
                Console.WriteLine("No awards");
            }

            foreach (var x in dict.OrderByDescending(s => s.Value.Count).ThenBy(d => d.Key))
            {
                Console.WriteLine("{0}: {1} awards", x.Key, x.Value.Count);

                for (int i = 0; i < x.Value.Count; i++)
                {
                    Console.WriteLine("--{0}", x.Value[i]);
                }
            }
        }
    }
}

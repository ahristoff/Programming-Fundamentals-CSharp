using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Problem_3.Football_Standings
{
    class Program
    {
        static void Main(string[] args)
        {
            var dictNameGoals = new Dictionary<string, int>();
            var dictNameStandings = new Dictionary<string, int>();


            string key = Console.ReadLine();
            var comand = Console.ReadLine();
    
            while (comand != "final")
            {       
                var com = comand.Split(new[] { ' ', ':' }, StringSplitOptions.RemoveEmptyEntries).ToList();

                var firstTeam = com[0];
                var secondTeam = com[1];
                var goalsFirstTeam = int.Parse(com[2]);
                var goalsSecondTeam = int.Parse(com[3]);

                int indexFrontFirstTeam = firstTeam.IndexOf(key);
                int indexBehindFirstTeam = firstTeam.LastIndexOf(key);

                var nameFirstTeamReeversed = firstTeam.Substring(indexFrontFirstTeam + key.Length, indexBehindFirstTeam - key.Length - indexFrontFirstTeam);
                var nameFirstTeam = nameFirstTeamReeversed.ToUpper().Reverse().ToArray();

                string nameFirstTeams = new string(nameFirstTeam);

                int indexFrontSecondTeam = secondTeam.IndexOf(key);
                int indexBehindSecondTeam = secondTeam.LastIndexOf(key);

                var nameSecondTeamReeversed = secondTeam.Substring(indexFrontSecondTeam + key.Length, indexBehindSecondTeam - key.Length - indexFrontSecondTeam);
                var nameSecondTeam = nameSecondTeamReeversed.ToUpper().Reverse().ToArray();
                string nameSecondTeams = new string(nameSecondTeam);

                if (!dictNameGoals.ContainsKey(nameFirstTeams))
                {
                    dictNameGoals[nameFirstTeams] = 0;
                }

                dictNameGoals[nameFirstTeams] += goalsFirstTeam;

                if (!dictNameGoals.ContainsKey(nameSecondTeams))
                {
                    dictNameGoals[nameSecondTeams] = 0;
                }

                dictNameGoals[nameSecondTeams] += goalsSecondTeam;

                if (!dictNameStandings.ContainsKey(nameFirstTeams))
                {
                    dictNameStandings[nameFirstTeams] = 0;
                }

                if (goalsFirstTeam > goalsSecondTeam)
                {
                    dictNameStandings[nameFirstTeams] += 3;
                }

                else if (goalsFirstTeam == goalsSecondTeam)
                {
                    dictNameStandings[nameFirstTeams] += 1;
                }

                else if (goalsFirstTeam < goalsSecondTeam)
                {
                    dictNameStandings[nameFirstTeams] += 0;
                }

                if (!dictNameStandings.ContainsKey(nameSecondTeams))
                {
                    dictNameStandings[nameSecondTeams] = 0;
                }

                if (goalsFirstTeam < goalsSecondTeam)
                {
                    dictNameStandings[nameSecondTeams] += 3;
                }

                else if (goalsFirstTeam == goalsSecondTeam)
                {
                    dictNameStandings[nameSecondTeams] += 1;
                }

                else if (goalsFirstTeam > goalsSecondTeam)
                {
                    dictNameStandings[nameSecondTeams] += 0;
                }

                comand = Console.ReadLine();
            }

            Console.WriteLine("League standings:");

            int place = 0;

            foreach (var x in dictNameStandings.OrderByDescending(s => s.Value).ThenBy(d => d.Key))
            {
                place++;

                Console.WriteLine("{0}. {1} {2}", place, x.Key, x.Value);
            }

            Console.WriteLine("Top 3 scored goals:");

            int Rankings = 0;

            foreach (var x in dictNameGoals.OrderByDescending(s => s.Value).ThenBy(d => d.Key))
            {
                Rankings++;

                Console.WriteLine("- {0} -> {1}", x.Key, x.Value);

                if (Rankings > 2)
                {
                    break;
                }
            }
        }
    }
}



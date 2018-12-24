using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_4___Winning_Ticket
{
    class Program
    {
       
        static void Main(string[] args)
        {
            var tickets = Console.ReadLine()
                .Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries).ToList();

            for (int i = 0; i < tickets.Count; i++)
            {
                tickets[i] = tickets[i].Trim();

                if (tickets[i].Length != 20)
                {
                    Console.WriteLine("invalid ticket");
                    continue;
                }

                else if (Right(tickets[i], '@') >= 6 && Left(tickets[i], '@') >= 6 && Math.Min(Left(tickets[i], '@'), Right(tickets[i], '@')) < 10)
                {
                    Console.WriteLine("ticket \"{0}\" - {1}@", tickets[i], Math.Min(Right(tickets[i], '@'), Left(tickets[i], '@')));
                    continue;
                }
                else if (Right(tickets[i], '@') == 10 && Left(tickets[i], '@') == 10)
                {
                    Console.WriteLine("ticket \"{0}\" - 10@ Jackpot!", new string('@', 20));
                    continue;
                }

                else if (Right(tickets[i], '#') >= 6 && Left(tickets[i], '#') >= 6 && Math.Min(Left(tickets[i], '#'), Right(tickets[i], '#')) < 10)
                {
                    Console.WriteLine("ticket \"{0}\" - {1}#", tickets[i], Math.Min(Right(tickets[i], '#'), Left(tickets[i], '#')));
                    continue;
                }
                else if (Right(tickets[i], '#') == 10 && Left(tickets[i], '#') == 10)
                {
                    Console.WriteLine("ticket \"{0}\" - 10# Jackpot!", new string('#', 20));
                    continue;
                }

                else if (Right(tickets[i], '$') >= 6 && Left(tickets[i], '$') >= 6 && Math.Min(Left(tickets[i], '$'), Right(tickets[i], '$')) < 10)
                {
                    Console.WriteLine("ticket \"{0}\" - {1}$", tickets[i], Math.Min(Right(tickets[i], '$'), Left(tickets[i], '$')));
                    continue;
                }
                else if (Right(tickets[i], '$') == 10 && Left(tickets[i], '$') == 10)
                {
                    Console.WriteLine("ticket \"{0}\" - 10$ Jackpot!", new string('$', 20));
                    continue;
                }

                else if (Right(tickets[i], '^') >= 6 && Left(tickets[i], '^') >= 6 && Math.Min(Left(tickets[i], '^'), Right(tickets[i], '^')) < 10)
                {
                    Console.WriteLine("ticket \"{0}\" - {1}^", tickets[i], Math.Min(Right(tickets[i], '^'), Left(tickets[i], '^')));
                    continue;
                }
                else if (Right(tickets[i], '^') == 10 && Left(tickets[i], '^') == 10)
                {
                    Console.WriteLine("ticket \"{0}\" - 10^ Jackpot!", new string('^', 20));
                    continue;
                }
                else
                {
                    Console.WriteLine("ticket \"{0}\" - no match", tickets[i]);
                    continue;
                }
            }
        }

        private static int Right(string text, char symbol)
        {
            int sum = 0;
            int maxSum = int.MinValue;

            for (int i = text.Length / 2; i < text.Length; i++)
            {

                if (text[i] == symbol)
                {
                    sum++;

                    if (maxSum < sum)
                    {
                        maxSum = sum;
                    }
                }

                else
                {
                    sum = 0;
                }
            }

            return maxSum;
        }

        private static int Left(string text, char symbol)
        {
            int sum = 0;
            int maxSum = int.MinValue;

            for (int i = 0; i < text.Length / 2; i++)
            {

                if (text[i] == symbol)
                {
                    sum++;

                    if (maxSum < sum)
                    {
                        maxSum = sum;
                    }
                }

                else
                {
                    sum = 0;
                }
            }

            return maxSum;
        }
    }
}

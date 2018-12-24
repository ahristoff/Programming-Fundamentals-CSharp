using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_6.Pizza_Ingredients
{
    class Program
    {
        static void Main(string[] args)
        {
            var jewelsGoldEarn = Console.ReadLine().Split().Select(int.Parse).ToList();

            int jewalsEarn = jewelsGoldEarn[0];
            int goldEarn = jewelsGoldEarn[1];

            var comand = Console.ReadLine();

            var sumEarn = 0;
            var sumExpense = 0;

            while (comand!= "Jail Time")
            {
                var input = comand.Split(' ').ToList();

                string earn = input[0];
                int expens = int.Parse(input[1]);

                for (int i = 0; i < earn.Length; i++)
                {

                    if (earn[i]=='%')
                    {
                        sumEarn += jewalsEarn;
                    }

                    else if (earn[i] == '$')
                    {
                        sumEarn += goldEarn;
                    }
                }

                sumExpense += expens;
               
                comand = Console.ReadLine();
            }

            if (sumEarn >= sumExpense)
            {
                Console.WriteLine("Heists will continue. Total earnings: {0}.", sumEarn - sumExpense);
            }
            if (sumEarn < sumExpense)
            {
                Console.WriteLine("Have to find another job. Lost: {0}.",sumExpense - sumEarn);
            }
        }
    }
}

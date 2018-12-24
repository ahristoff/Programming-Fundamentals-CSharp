using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_1.Charity_Marathon
{
    class Program
    {
        static void Main(string[] args)
        {
            var days = int.Parse(Console.ReadLine());
            var numOfRunners = long.Parse(Console.ReadLine());
            var numOfLaps = int.Parse(Console.ReadLine());
            var trackLenght = long.Parse(Console.ReadLine());
            var trackCapacity = int.Parse(Console.ReadLine());
            var moneyPerKm = decimal.Parse(Console.ReadLine());

            if (numOfRunners > trackCapacity * days)
            {
                numOfRunners = trackCapacity * days;
            }

            var totalKm = (numOfRunners * numOfLaps * trackLenght) / 1000;
            var moneyRaised = totalKm * moneyPerKm;

            Console.WriteLine("Money raised: {0:f2}", moneyRaised);
        }
    }
}

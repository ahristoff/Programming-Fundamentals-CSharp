using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_1.Sino_The_Walker
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputTime = Console.ReadLine().Split(':').Select(long.Parse).ToList();
            var numSteps = long.Parse(Console.ReadLine());
            var secProStep = long.Parse(Console.ReadLine());

            var timeLeaveInSec = numSteps * secProStep;
            var inputTimeInSec = inputTime[0] * 3600 + inputTime[1] * 60 + inputTime[2];
            var totalTime = timeLeaveInSec + inputTimeInSec;

            var hours = (totalTime / 3600);
            var min = (totalTime - hours * 3600) / 60;
            var sec = (totalTime - hours * 3600 - min * 60) % 60;
            var hoursArr = hours % 24;

            Console.WriteLine("Time Arrival: {0:00}:{1:00}:{2:00}", hoursArr, min, sec);
        }
    }
}

using System;
using System.Numerics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Centuries_to_Nanoseconds
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int centuries = int.Parse(Console.ReadLine());

            int years = 100 * centuries;
            int days = (int)(365.2422 * years);
            int hours = 24 * days;
            int min = 60 * hours;
            ulong sec = ( 60 *(ulong)min);
            ulong milisec = (1000 * (ulong)sec);
            ulong microsec = (1000 * (ulong)milisec);
            BigInteger nanosec = 1000 * (BigInteger)microsec;

            Console.WriteLine("{0} centuries = {1} years = {2} days = {3} hours = {4} minutes = {5} seconds = {6} milliseconds = {7} microseconds = {8} nanoseconds", centuries, years, days, hours, min,sec,milisec,microsec,nanosec);
        }
    }
}

using System;

namespace _2._Circle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            double r = double.Parse(Console.ReadLine());

            Console.WriteLine("{0:f12}", Math.PI * r * r);
        }
    }
}

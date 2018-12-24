using System;

namespace _4._Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            int persons = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());

            int courses = (int)Math.Ceiling(persons / (double)capacity);

            Console.WriteLine(courses);
        }
    }
}

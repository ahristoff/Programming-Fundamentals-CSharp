using System;

namespace _917._Print_Part_of_the_ASCII_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());

            for (int i = n1; i <= n2; i++)
            {
                Console.Write("{0} ", (char)i);
            }

            Console.WriteLine();
        }
    }
}

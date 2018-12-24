using System;

namespace _9._Reverse_Characters
{
    class Program
    {
        static void Main(string[] args)
        {
            char a = char.Parse(Console.ReadLine());
            char b = char.Parse(Console.ReadLine());
            char c = char.Parse(Console.ReadLine());

            char d = a;
            a = c;
            c = d;

            Console.Write(a);
            Console.Write(b);
            Console.Write(c);
        }
    }
}

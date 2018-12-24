using System;

namespace Problem_913._Decrypting_Messages
{
    class Program
    {
        static void Main(string[] args)
        {
            int key = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                char charactar = char.Parse(Console.ReadLine());

                int num = ((int)charactar + key);
                char result = (char)num;

                Console.Write(result);
            }
        }
    }
}

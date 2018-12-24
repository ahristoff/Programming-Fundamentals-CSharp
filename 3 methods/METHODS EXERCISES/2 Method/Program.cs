using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Hello__Name_
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());

            Console.WriteLine(GetMax(n1,n2,n3));
        }

        private static int GetMin(int n1, int n2)
        {
            int result = Math.Max(n1, n2);
            return result; 
        }

        private static int GetMax(int n1, int n2, int n3)
        {
            int result = Math.Max(n3, GetMin(n1,n2));
            return result;
        }       
    }
}

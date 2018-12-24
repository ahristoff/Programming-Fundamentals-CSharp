using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Numbers_in_Reversed_Orde
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = double.Parse(Console.ReadLine());

            Console.WriteLine(ReversedNum(n));
        }

        private static string ReversedNum(double n)
        {
            string numString = n.ToString();             
            string reversedString = null;              

            for (int i = numString.Length - 1; i >=0 ; i--)
            {
                reversedString += numString[i];                        
            }                                               
           
            return reversedString;
        }
    }
}

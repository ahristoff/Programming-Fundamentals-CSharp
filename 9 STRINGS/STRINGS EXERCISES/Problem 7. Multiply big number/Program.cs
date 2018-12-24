using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
namespace Problem_7.Multiply_big_number
{
    class Program
    {
        static void Main(string[] args)
        {            
            var num1 = Console.ReadLine();
            var num2 = int.Parse(Console.ReadLine());

            var result = new StringBuilder();
            var remainder = 0;

            for (int i = num1.Length - 1; i >=0 ; i--)
            {
                var sum = 0;

                sum = num2 * int.Parse(num1[i].ToString());
                sum = sum + remainder;

                if (sum > 9)
                {
                    remainder = sum / 10;
                    sum = sum % 10;                  
                }

                else
                {
                    remainder = 0;
                }

                result.Append(sum);
            }

            if (remainder > 0)
            {
                result.Append(remainder);
            }

            var totalResult = result.ToString().ToCharArray();
            Array.Reverse(totalResult);

            Console.WriteLine(totalResult);
        }
    }
}

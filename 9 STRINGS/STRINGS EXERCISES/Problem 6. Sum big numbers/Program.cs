using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem_6.Sum_big_numbers
{
    class Program
    {
        static void Main(string[] args)
        {

            var num1 = Console.ReadLine();
            var num2 = Console.ReadLine();

            if (num1.Length > num2.Length)
            {
                var diff = num1.Length - num2.Length;

                for (int i = 0; i < diff; i++)
                {
                    num2 = num2.Insert(0, "0");
                }
            }

            else if (num2.Length > num1.Length)
            {
                var diff = num2.Length - num1.Length;

                for (int i = 0; i < diff; i++)
                {
                    num1 = num1.Insert(0, "0");
                }
            }

            var result = new StringBuilder();
            var remainder = 0;

            for (int i = num1.Length - 1; i >= 0; i--)
            {
                var sum = 0;

                sum = int.Parse(num1[i].ToString()) + int.Parse(num2[i].ToString());
                sum = sum + remainder;

                if (sum > 9)
                {
                    sum = sum % 10;
                    remainder = 1;
                }
                else
                {
                    remainder = 0;
                }

                result.Append(sum);
            }

            if (remainder == 1)
            {
                result.Append(1);
            }

            var totalResult = result.ToString().ToCharArray();
            Array.Reverse(totalResult);

            Console.WriteLine(totalResult);
        }
    }
}

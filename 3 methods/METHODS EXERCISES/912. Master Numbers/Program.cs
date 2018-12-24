using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _912.Master_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            
            for (int i1 = 10; i1 <= n; i1++)
            {
                var num = i1.ToString();
               
                CheckMasterNumbers(num, 0);               
            }
        }

        private static void CheckMasterNumbers(string num, int count)
        {

            for (int i = 0; i < num.Length / 2; i++)
            {

                if (num[i] == num[num.Length - i - 1])
                {
                    count++;
                }
            }

            if (count == num.Length / 2)
            {
                int result = int.Parse(num);

                int sum = 0;
                int number = result;
                int count2 = 0;

                while (number > 0)
                {
                    if ((number % 10) % 2 == 0)
                    {
                        count2++;
                    }

                    sum += number % 10;
                    number /= 10;
                }

                if (sum % 7 == 0)
                {

                    if (count2 > 0)
                    {
                        Console.WriteLine(result);
                    }
                }
            }
        }
    }
}

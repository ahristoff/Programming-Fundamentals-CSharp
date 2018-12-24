

namespace _8.Multiply_Evens_by_Odds
{
    using System;
    public class Multiple
    {
        public static void Main()
        {
            int num = Math.Abs(int.Parse(Console.ReadLine()));

            Console.WriteLine(MultipleEvenSumAndOddSum(num));          
        }

        private static int SumOdd(int num)
        {
            int sumOdd = Sum(num, 1);
            return sumOdd;
        } 

        private static int EvenSum(int num)
        {
            int sumEven = Sum(num, 0);
            return sumEven;
        }

        public static int Sum(int num, int remainder)
        {
            int sum = 0;

            while (num > 0)
            {
                
                if (num % 2 == remainder)
                {
                    sum += num % 10;
                }
               
                num = num / 10;
            }

            return sum;
        }

        private static int MultipleEvenSumAndOddSum(int num)
        {
            int res = EvenSum(num) * SumOdd(num);
            return res;
        }
    }
}

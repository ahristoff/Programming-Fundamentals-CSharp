using System;

namespace _3._English_Name_оf_The_Last_Digit
{
    class Program
    {
        static void Main()
        {
            long n = Math.Abs(long.Parse(Console.ReadLine()));

            long last = LastDigit(n);
            Console.WriteLine(ConvertDigitToWord(last));
        }

        private static string ConvertDigitToWord(long last)
        {
            string digitAsWord = null;

            switch (last)
            {
                case 0:
                    digitAsWord = "zero";
                    break;
                case 1:
                    digitAsWord = "one";
                    break;
                case 2:
                    digitAsWord = "two";
                    break;
                case 3:
                    digitAsWord = "three";
                    break;
                case 4:
                    digitAsWord = "four";
                    break;
                case 5:
                    digitAsWord = "five";
                    break;
                case 6:
                    digitAsWord = "six";
                    break;
                case 7:
                    digitAsWord = "seven";
                    break;
                case 8:
                    digitAsWord = "eight";
                    break;
                case 9:
                    digitAsWord = "nine";
                    break;

            }
            return digitAsWord;
        }

        private static long LastDigit(long n)
        {
            long lastDig = n % 10;
            return lastDig;
        }
    }
}

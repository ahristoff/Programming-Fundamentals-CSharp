using System;
using System.Numerics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _918_Different_Integers_Size
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger n = BigInteger.Parse(Console.ReadLine());

            string result;

            if (n >= -128 && n < 0)
            {
                result = $"{n} can fit in:\n* sbyte\n* short\n* int\n* long";
            }

            else if (n<-128&&n>=-32768)
            {
                result = $"{n} can fit in:\n* short\n* int\n* long";
            }

            else if (n < -32768 && n >= -2147483648)
            {
                result = $"{n} can fit in:\n* int\n* long";
            }

            else if (n < -2147483648 && n >= -9223372036854775808)
            {
                result = $"{n} can fit in:\n* long";
            }

            else if (n>=0&&n<=127)
            {
                result = $"{n} can fit in:\n* sbyte\n* byte\n* short\n* ushort\n* int\n* uint\n* long";
            }

            else if (n>127&&n<=255)
            {
                result = $"{n} can fit in:\n* byte\n* short\n* ushort\n* int\n* uint\n* long";
            }

            else if (n > 255 && n <= 32767)
            {
                result = $"{n} can fit in:\n* short\n* ushort\n* int\n* uint\n* long";
            }

            else if (n > 32767 && n <= 65535)
            {
                result = $"{n} can fit in:\n* ushort\n* int\n* uint\n* long";
            }

            else if (n > 65535 && n <= 2147483647)
            {
                result = $"{n} can fit in:\n* int\n* uint\n* long";
            }

            else if (n > 2147483647 && n <= 4294967295)
            {
                result = $"{n} can fit in:\n* uint\n* long";
            }

            else if (n > 4294967295 && n <= 9223372036854775807)
            {
                result = $"{n} can fit in:\n* long";
            }

            else
            {
                result = $"{n} can't fit in any type";
            }

            Console.WriteLine(result);
        }
    }
}

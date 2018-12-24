using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_11._5_Different_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            int count = 0;

            for (int i1 = num1; i1 <= num2; i1++)
            {

                for (int i2 = num1; i2 <= num2; i2++)
                {

                    for (int i3 = num1; i3 <= num2; i3++)
                    {

                        for (int i4 = num1; i4 <= num2; i4++)
                        {

                            for (int i5 = num1; i5 <= num2; i5++)
                            {

                                if (num1 <= i1 && i1 < i2 && i2 < i3 && i3 < i4 && i4 < i5 && i5 <= num2)
                                {

                                    Console.WriteLine("{0} {1} {2} {3} {4}",i1,i2,i3,i4,i5);

                                    count = 1;
                                }
                            }
                        }
                    }
                }
            }

            if (count==0)
            {
                Console.WriteLine("No");
            }
        }
    }
}

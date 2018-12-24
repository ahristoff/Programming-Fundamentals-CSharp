using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_9.___Jump_Around
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            
            var firstNumber = num[0];
            var size = 0;
            var sum = firstNumber;

            while (true)
            {
                
                if (num.Count >= size + firstNumber)
                {
                    var nextNumber = num[firstNumber];
                    sum += nextNumber;
                    size = firstNumber + size;
                    firstNumber = nextNumber;                  
                }

                else if (size - firstNumber >= 0)
                {
                    var nextNumber = num[num.Count - 1 - firstNumber];
                    sum += nextNumber;
                    size = size - firstNumber;
                    firstNumber = nextNumber;
                }

                else
                {
                    break;
                }
            }

            Console.WriteLine(sum);
        }
    }
}

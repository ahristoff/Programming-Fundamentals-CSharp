using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Sum_Adjacent_Equal_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {            
            List<decimal> num = Console.ReadLine().Split(' ').Select(decimal.Parse).ToList();

            for (int j = 0; j < num.Count; j++)
            {

                for (int i = 0; i < num.Count-1; i++)
                {         
                    
                    if (num[i] == num[i + 1])
                    {
                        num[i] = num[i] + num[i + 1];
                        num.RemoveAt(i + 1);
                    }                   
                }
            }

            Console.WriteLine(string.Join(" ", num));
        }
    }
}

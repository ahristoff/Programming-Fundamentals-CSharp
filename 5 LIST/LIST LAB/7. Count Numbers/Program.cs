using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.Count_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var numInput = Console.ReadLine().Split(' ').Select(int.Parse).OrderBy(n => n).ToList();
            
            var num = numInput.Distinct().ToList();

            for (int i = 0; i < num.Count; i++)
            {
                int count = 0;

                for (int j = 0; j < numInput.Count; j++)
                {

                    if (num[i] == numInput[j])
                    {
                        count++;
                    }
                }

                Console.WriteLine("{0} -> {1}", num[i], count);
            }
        }
    }
}

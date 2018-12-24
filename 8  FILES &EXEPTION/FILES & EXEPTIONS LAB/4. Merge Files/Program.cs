using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _4.Merge_Files
{
    class Program
    {
        static void Main(string[] args)
        {
            var input1 = File.ReadAllLines("input1.txt").ToList();
            var input2 = File.ReadAllLines("input2.txt").ToList();

            var res = new List<string>();

            for (int i = 0; i < Math.Min(input1.Count,input2.Count); i++)
            {
                res.Add(input1[i]);
                res.Add(input2[i]); 
            }
            File.WriteAllLines("output.txt", res);
            Console.WriteLine(string.Join("\r\n",res));
        }
    }
}

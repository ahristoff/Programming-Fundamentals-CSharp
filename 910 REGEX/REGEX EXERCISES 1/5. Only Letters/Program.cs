using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _5.Only_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            var reg1 = new Regex(@"\d+");
            var res1 = reg1.Split(input);

            var reg2 = new Regex(@"[A-Za-z]+");
            var res2 = reg2.Split(input);

            string result = "";

            if (res1[0]!="")
            {
                result = res1[0];
            }
            
            for (int i = 1; i < res1.Length; i++)
            {
                if (res1[i]!="")
                {
                    result += res1[i][0]+res1[i];
                }             
            }

            result = result + res2[res2.Length-1];
           
            Console.WriteLine(result.Trim());
        }
    }
}

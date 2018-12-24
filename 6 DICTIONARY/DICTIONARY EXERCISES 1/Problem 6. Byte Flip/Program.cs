using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_6.Byte_Flip
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ').ToList();

            input.RemoveAll(x => x.Length != 2);

            var list = new List<string>();

            for (int i = 0; i < input.Count; i++)
            {
                string res = null;
                
                for (int j = input[i].Length - 1; j >= 0; j--)
                {                   
                    res += input[i][j];
                }

                list.Add(res);
            }

            list.Reverse();
            
            string output = null;
           
            foreach (var x in list)
            {
                int value = Convert.ToInt32(x, 16);
                output += (char)value;
            }

            Console.WriteLine(output);           
        } 
    }
}

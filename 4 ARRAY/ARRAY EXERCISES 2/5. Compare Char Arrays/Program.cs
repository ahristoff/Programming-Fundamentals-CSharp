using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Compare_Char_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {                                                      //var1
            
            char[] one = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();           
            char[] two = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();

            int lenght = Math.Min(one.Length, two.Length); 

            for (int i = 0; i < lenght; i++)
            {
                if (one[i] > two[i])
                {
                    Console.WriteLine(two);
                    Console.WriteLine(one);
                    break;                    
                } 

                else if (one[i] < two[i])
                {
                    Console.WriteLine(one);
                    Console.WriteLine(two);
                    break;
                }

                else if (one[i] == two[i] && one.Length == two.Length)
                {
                    Console.WriteLine(one);
                    Console.WriteLine(two);
                    break;
                }

                else if (one[i] == two[i] && one.Length != two.Length)
                {
                    if (one.Length > two.Length)
                    {
                        Console.WriteLine(two);
                        Console.WriteLine(one);
                        break;
                       
                    }
                    else if (one.Length < two.Length)
                    {
                        Console.WriteLine(one);
                        Console.WriteLine(two);
                        break;
                    }
                }
            }

            //-----------------------------------------------------------------------------

            //string one = Console.ReadLine();                               //var 2
            //string two = Console.ReadLine();
            //int res = string.Compare(one, two, false);

            //if (res == 0)
            //{
            //    Console.WriteLine(one);
            //    Console.WriteLine(two);
            //}
            //if (res > 0)
            //{
            //    Console.WriteLine(two);
            //    Console.WriteLine(one);
            //}
            //if (res < 0)
            //{
            //    Console.WriteLine(one);
            //    Console.WriteLine(two);
            //}
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.Sum_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int[] num1 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] num2 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();


            int[] arr1 = new int[Math.Max(num1.Length, num2.Length)];
            int[] arr2 = new int[Math.Max(num1.Length, num2.Length)];

            if (num1.Length > num2.Length)
            {             

                for (int i = 0; i < num1.Length; i++)
                {                   
                    arr1[i] = num1[i];
                    arr2[i] = num2[i % num2.Length];
                }                
            }

            else if (num1.Length < num2.Length)
            {              
                for (int i = 0; i < num2.Length; i++)
                {
                    arr1[i] = num1[i % num1.Length];
                    arr2[i] = num2[i];
                }
            }

            else
            {
                for (int i = 0; i < num1.Length; i++)
                {
                    arr1[i] = num1[i];
                }

                for (int i = 0; i < num2.Length; i++)
                {
                    arr2[i] = num2[i];
                }
            }          

            var res = arr1.Zip(arr2, (x, y) => x + y).ToList();
        
            Console.WriteLine(String.Join(" ", res));
        }
    }
}

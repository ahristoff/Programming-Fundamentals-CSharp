using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.Most_Frequent_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int counter = 0;
            int counterMax = 0;
            int mostFreqNum = 0;
          
            for (int j = 0; j < arr.Length; j++)
            {               
                for (int i = 0; i < arr.Length; i++)
                {                   
                    if (arr[j] == arr[i])
                    {
                        counter++;

                        if (counter > counterMax)
                        {
                            counterMax = counter;
                            mostFreqNum = arr[j];                            
                        }                        
                    }                   
                }

                counter = 0;
            }
              
            Console.WriteLine(mostFreqNum);
            //Console.WriteLine(counterMax);   
        }
    }
}

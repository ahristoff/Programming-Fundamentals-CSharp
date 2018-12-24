using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_15.Balanced_Brackets
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var res = new List<string>();

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine();
                res.Add(input);
            }

            int count1 = 0;
            int count2 = 0;
            int count3 = 0;

            for (int i = 0; i < res.Count; i++)
            {
                if (res[i] == ")")
                {

                    for (int j = 0; j <= i; j++)
                    {
                        if (res[i] == ")" && res[j] != "(")
                        {
                            count3++;                            
                        }
                    }

                    if (count3 == i+1)
                    {

                        Console.WriteLine("UNBALANCED");
                        return;
                    }

                    count3 = 0;
                }
                                                     
                if (res[i]=="(")
                {
                    
                    count1 ++;

                    for (int j =i ; j < res.Count; j++)
                    {

                        if (res[j]==")")
                        {

                            for (int x = i + 1; x < j; x++)
                            {

                                if (res[x] != "(")
                                {
                                    count2++;
                                }
                            }                                                 
                        }
                    }

                    count2 = 0;
                }

                count1 = 0;              
            }
           
            if (count1 == count2)
            {
                Console.WriteLine("BALANCED");
            }

            if (count1 != count2)
            {
                Console.WriteLine("UNBALANCED");
            }
        }
    }
}

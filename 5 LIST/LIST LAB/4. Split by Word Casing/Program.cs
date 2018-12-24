using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Split_by_Word_Casing
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine().Split(new Char[] { ',', ';', ':', '.', '!', '(', ')', '"', '\'', '\\', '/', '[', ']', ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();

            List<string> LowLetter = new List<string> ();
            List<string> UpLetter = new List<string>();
            List<string> MixLetter = new List<string>();

            int countlow = 0;
            int countup = 0;
            
            foreach (var x in text)
            {
                for (int i = 0; i < x.Length; i++)
                {
                    if (char.IsLower(x[i]))
                    {
                        countlow++;                        
                    }

                    else if (char.IsUpper(x[i]))
                    {
                        countup++;
                    }
                }

                if (countlow == x.Length)
                {
                    LowLetter.Add(x);                    
                }
                                                
                else if (countup == x.Length)
                {
                    UpLetter.Add(x);                    
                }
                
                else
                {
                    MixLetter.Add(x);
                }

                countlow = 0;
                countup = 0;
            }

            Console.WriteLine("Lower-case: {0}", string.Join(", ", LowLetter));         
            Console.WriteLine("Mixed-case: {0}", string.Join(", ", MixLetter));          
            Console.WriteLine("Upper-case: {0}", string.Join(", ", UpLetter));           
        }
    }
}

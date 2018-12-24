using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_6._DNA_Sequences
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var list = new List<string>();

            string nucleicAcidSequence  = null;
            int charCount = 0;

            for (int i1 = 1; i1 <= 4; i1++)
            {

                for (int i2 = 1; i2 <= 4; i2++)
                {

                    for (int i3 = 1; i3 <= 4; i3++)
                    {

                        if (i1 + i2 + i3 >= n)
                        {
                            nucleicAcidSequence  = $"O{i1}{i2}{i3}O".Replace('1', 'A').Replace('2', 'C').Replace('3', 'G').Replace('4', 'T');
                        }

                        else
                        {
                            nucleicAcidSequence  = $"X{i1}{i2}{i3}X".Replace('1', 'A').Replace('2', 'C').Replace('3', 'G').Replace('4', 'T');
                        }

                        list.Add(nucleicAcidSequence);
                    }
                }
            }
            foreach (var x in list)
            {

                charCount++;

                if (charCount % 4 == 0)
                {
                    Console.WriteLine(x);
                }

                else
                {
                    Console.Write(x + " ");
                }
            }
        }
    }
}

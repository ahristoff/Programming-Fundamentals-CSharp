using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_2___Command_Interpreter
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = Console.ReadLine().Trim()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();

            var comand = Console.ReadLine();

            while (comand != "end")
            {
                var com = comand.Trim().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();

                if (com[0] == "reverse")
                {
                    var  start = int.Parse(com[2]);
                    var end = int.Parse(com[4]);

                    if (start  < 0 || start > list.Count-1 || end < 0 || end + start > list.Count)
                    {
                        Console.WriteLine("Invalid input parameters.");
                        comand = Console.ReadLine();
                        continue;                 
                    }

                    else
                    {                       
                        list.Reverse(start, end);
                    }
                }
                if (com[0] == "sort")
                {
                    var start = int.Parse(com[2]);
                    var end = int.Parse(com[4]);
            
                    if (start < 0 || start > list.Count - 1 || end < 0 || end + start > list.Count)
                    {
                        Console.WriteLine("Invalid input parameters.");
                        comand = Console.ReadLine();
                        continue;
                    }

                    else
                    {                       
                        list.Sort(start, end, StringComparer.InvariantCulture);
                    }                            
                }

                if (com[0] == "rollLeft")
                {
                    int times = int.Parse(com[1]);

                    if (times < 0)
                    {
                        Console.WriteLine("Invalid input parameters.");
                        comand = Console.ReadLine();
                        continue;
                    }

                    else
                    {
                        for (int i = 0; i < times % list.Count; i++)
                        {
                            var substitute = list[0];

                            for (int j = 1; j < list.Count; j++)
                            {
                                list[j - 1] = list[j];
                            }

                            list[list.Count - 1] = substitute;
                        }
                    }                  
                }

                if (com[0] == "rollRight")
                {
                    int times = int.Parse(com[1]);

                    if (times < 0)
                    {
                        Console.WriteLine("Invalid input parameters.");
                        comand = Console.ReadLine();
                        continue;
                    }

                    else
                    {
                        for (int i = 0; i < times % list.Count; i++)
                        {
                            var substitute = list[list.Count - 1];

                            for (int j = list.Count - 1; j > 0; j--)
                            {
                                list[j] = list[j - 1];
                            }

                            list[0] = substitute;
                        }
                    }                                
                }     
                
                comand = Console.ReadLine();
            }
          
            Console.WriteLine("[{0}]",string.Join(", ",list));
        }
    }
}

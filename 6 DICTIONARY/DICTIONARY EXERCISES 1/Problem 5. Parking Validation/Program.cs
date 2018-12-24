using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_5.Parking_Validation
{
    class Program
    {
        static void Main(string[] args)
        {
            var dict = new Dictionary<string, string>();

            int n = int.Parse(Console.ReadLine());

            while (n>=0)
            {
               
                for (int i = 0; i < n; i++)
                {
                    var com = Console.ReadLine().Split(' ').ToList();
                    var name = com[1];

                    if (com[0] == "register")
                    {
                        var plate = com[2];

                        if ((!char.IsLetter(plate[0]) || !char.IsUpper(plate[0])) || (!char.IsLetter(plate[1]) || !char.IsUpper(plate[1])) || !char.IsDigit(plate[2]) || !char.IsDigit(plate[3]) || !char.IsDigit(plate[4]) || !char.IsDigit(plate[5]) || (!char.IsLetter(plate[6]) || !char.IsUpper(plate[6])) || (!char.IsLetter(plate[7]) || !char.IsUpper(plate[7])))
                        {
                            Console.WriteLine("ERROR: invalid license plate {0}", plate);
                            break;
                        }

                        if (dict.ContainsValue(plate))
                        {
                            Console.WriteLine("ERROR: license plate {0} is busy", plate);
                            break;
                        }

                        if (!dict.ContainsKey(name))
                        {
                            dict[name] = plate;
                            Console.WriteLine("{0} registered {1} successfully", name, plate);
                            break;
                        }

                        else
                        {
                            Console.WriteLine("ERROR: already registered with plate number {0}", plate);
                            break;
                        }                     
                    }

                    if (com[0] == "unregister")
                    {

                        if (!dict.ContainsKey(name))
                        {
                            Console.WriteLine("ERROR: user {0} not found", name);
                            break;
                        }

                        else
                        {
                            dict.Remove($"{name}");
                            Console.WriteLine("user {0} unregistered successfully", name);
                            break;
                        }
                    }
                }

                n--;
            }

            foreach (var x in dict)
            {
                Console.WriteLine("{0} => {1}",x.Key,x.Value);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.___Phonebook
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> phone = new Dictionary<string, string>();

            var com = Console.ReadLine();

            while (com != "END")
            {
                var res = com.Split(' ').ToList();

                if (res[0] == "A")
                {
                    phone[res[1]] = res[2];
                }

                if (res[0] == "S")
                {

                    if (phone.ContainsKey(res[1]))
                    {
                        foreach (var x in phone)
                        {
                            if (x.Key == res[1])
                            {
                                Console.WriteLine("{0} -> {1}", x.Key, x.Value);
                            }
                        }
                    }

                    else
                    {
                        Console.WriteLine("Contact {0} does not exist.", res[1]);
                    }
                }

                com = Console.ReadLine();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
namespace _3.Camera_View
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<string>();

            var line = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var input = Console.ReadLine();

            var skip = line[0];
            var take = line[1];
            
            string text = $"{input}";
            string pattern = @"\|<";

            var res = Regex.Split(text, pattern).ToList();

            for (int i = 1; i < res.Count; i++)
            {

                if (res[i].Length > skip && res[i].Length<=skip+take)
                {
                    res[i] = res[i].Remove(0, skip);
                    list.Add(res[i]);
                }

                if (res[i].Length > skip + take)
                {
                    res[i] = res[i].Remove(0, skip);
                    res[i] = res[i].Remove(take-1 +1);
                    list.Add(res[i]);
                }
            }

            Console.WriteLine(string.Join(", ", list));
        }
    }
}

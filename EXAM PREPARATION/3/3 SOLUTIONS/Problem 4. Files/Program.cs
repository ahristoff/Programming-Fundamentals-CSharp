using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Problem_4.Files
{
    class Program
    {
        static void Main(string[] args)
        {
            var nestedDict = new Dictionary<string, Dictionary<string, long>>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine()
                    .Split(new string[] { "\\", ";" }, StringSplitOptions.RemoveEmptyEntries).ToList();

                var root = input[0];
                var size = long.Parse(input[input.Count - 1]);
                var fileNameAndExtention = input[input.Count - 2];


                if (!nestedDict.ContainsKey(root))
                {
                    nestedDict[root] = new Dictionary<string, long>();
                }

                if (!nestedDict[root].ContainsKey(fileNameAndExtention))
                {
                    nestedDict[root][fileNameAndExtention] = 0;
                }

                nestedDict[root][fileNameAndExtention] = size;
            }

            var com = Console.ReadLine().Split(' ').ToList();

            var queryExtention = com[0].Trim();
            var queryRoot = com[2].Trim();

            bool existFile = false;

            foreach (var x in nestedDict)
            {

                foreach (var y in x.Value.OrderByDescending(s => s.Value).ThenBy(s => s.Key))
                {

                    if (y.Key.EndsWith(queryExtention) && queryRoot == x.Key)
                    {
                        Console.WriteLine("{0} - {1} KB", y.Key, y.Value);

                        existFile = true;
                    }
                }
            }

            if (existFile == false)
            {
                Console.WriteLine("No");
            }
        }
    }
}


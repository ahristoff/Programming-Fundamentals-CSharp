using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _5.Folder_Size
{
    class Program
    {
        static void Main(string[] args)
        {
            var fileSize = Directory.GetFiles("FindMySize");

            var total = 0l;

            foreach (var x in fileSize)
            {
                var fileInfo = new FileInfo(x);
                total += fileInfo.Length;
            }

            var totalLenght = (total / 1024.0 / 1024.0).ToString();

            File.WriteAllText("Output.txt", totalLenght);
            Console.WriteLine(totalLenght);
        }
    }
}

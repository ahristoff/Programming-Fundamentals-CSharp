using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_5._._.Word_in_Plural
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();

            var list = new List<char>();

            foreach (var x in word)
            {
                list.Add(x);
            }

            if (list[list.Count-1]=='y')
            {

                list[list.Count - 1] = 'i';
                list.Add('e');
                list.Add('s');
            }

            else if (list[list.Count - 1] == 'o'|| list[list.Count - 1] == 's'|| list[list.Count - 1] == 'x'|| list[list.Count - 1] == 'z')
            {

                list.Add('e');
                list.Add('s');
            }

            else if ((list[list.Count - 2] == 'c' && list[list.Count - 1] == 'h') || (list[list.Count - 2] == 's' && list[list.Count - 1] == 'h'))
            {

                list.Add('e');
                list.Add('s');
            }

            else
            {
                list.Add('s');
            }

            list.ForEach(Console.Write);
        }
    }
}

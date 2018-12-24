using System;


namespace _7.Greater_of_Two_Values
{  
    public class Max
    {      
        public static void Main()
        {
            string input = Console.ReadLine();
            
            if (input == "int" )
            {
                int first = int.Parse(Console.ReadLine());
                int second = int.Parse(Console.ReadLine());

                var res = GetMax(first, second);

                Console.WriteLine(res);
            }

            else if (input == "char")
            {
                char first = char.Parse(Console.ReadLine());
                char second = char.Parse(Console.ReadLine());

                var res = GetMax(first, second);
                Console.WriteLine(res);
            }

            else if (input == "string")
            {
                string first = Console.ReadLine();
                string second = Console.ReadLine();

                GetMax(first, second);
                Console.WriteLine(GetMax(first, second));
            }
        }

        public static int GetMax(int first, int second)
        {
            var res = Math.Max(first, second);
            return res;
        }

        public static char GetMax(char first, char second)
        {
            char res = (char)Math.Max((int)first, (int)second);
            return res;
        }

        public static string GetMax(string first, string second)
        {
            if (first.CompareTo(second) >= 0)
            {
                return first;
            }

            else
            {
                return second;
            }
        }
    }
}

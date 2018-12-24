using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.___Blank_Receipt
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintReceiptHeader();
            DashLine();
            PrintBodyHeader();
            DashLine();
            PrintReceiptFooter();
        }

        public static void PrintReceiptHeader()
        {
            Console.WriteLine("CASH RECEIPT");
        }

        public static void DashLine()
        {
            Console.WriteLine("{0}", new string('-', 30));
        }

        public static void PrintBodyHeader()
        {
            Console.WriteLine("Charged to{0}", new string('_', 20));
            Console.WriteLine("Received by{0}", new string('_', 19));
        }

        public static void PrintReceiptFooter()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            char symbol = '\u00A9';
            Console.WriteLine($"{symbol} SoftUni");
        }
    }
}


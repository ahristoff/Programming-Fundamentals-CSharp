﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Sort_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<decimal> num = Console.ReadLine().Split(' ').Select(decimal.Parse).ToList();

            num.Sort();

            Console.WriteLine(string.Join(" <= ",num));
        }
    }
}

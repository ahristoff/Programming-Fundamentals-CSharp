﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _915_Fast_Prime_Checker___Refactor
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 2; i <= n; i++)
            {
                bool diff = true;

                for (int j = 2; j <= Math.Sqrt(i); j++)
                {

                    if (i % j == 0)
                    {

                        diff = false;
                        break;
                    }
                }
                Console.WriteLine($"{i} -> {diff}");
            }
        }
    }
}

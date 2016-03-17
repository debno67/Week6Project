﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loopWithBreak
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            int n = int.Parse(Console.ReadLine());
            decimal factorial = 1;

            while (true)
            {
                if (n <= 1)
                {
                    break;
                }

                factorial *= n;
                n--;
            }

            Console.WriteLine("n! = " + factorial);
            
        }
    }
}

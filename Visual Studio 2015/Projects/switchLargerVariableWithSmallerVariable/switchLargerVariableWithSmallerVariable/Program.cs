using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switchLargerVariableWithSmallerVariable
{
    class Program
    {
        static void Main(string[] args)
        {

            //declare 2 vars
            //if statement

            //Console.WriteLine("Enter a number:");
            //Console.WriteLine("Enter another number");

            //     int x = 10;
            //     int y = 5;
            //     int temp = 0;

            // if (x > y)
            // {
            //   Console.WriteLine("x = " + x + " y= " + y + "temp= " + temp);
            // temp = y;

            // Console.WriteLine("x = " + x + " y= " + y + "temp= " + temp);
            // y = y;

            //Console.WriteLine("x = " + x + " y= " + y + "temp= " + temp);
            //x = temp;
            //Console.WriteLine("x = " + x + " y= " + y + "temp= " + temp);

            //}
            //}
            //}
            //}

            //  int x = 10;
            //  int y = 5;
            //  int temp = x;

            //  if (x = y)
            // {

            //     x = y;
            //     y = temp;
            //     Console.WriteLine("x is " + x + "  and y is " + y);
            // }

            //            else
            //          {
            //            Console.WriteLine("x is " + x + "and y is " + y);
            //      }
            //}
            //    }
            //} 

            Console.WriteLine("Enter a value for a: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter a value for b: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter a value for c: ");
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine("Original values a = {0}; b = {1}", a, b);

            if (a > b)
            {
                c = a;
                a = b;
                b = c;

            }
            Console.WriteLine("Exchanged values a = {0}; b = {1}", a, b);
        }
    }
}



    
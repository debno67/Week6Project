using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace findBiggestNumberUsingNested
{
    class Program
    {
        static void Main(string[] args)
        {

            int a = 5;
            int b = 50;
            int c = 50;

            if (a > b && a > c)
            {
                Console.WriteLine(a);
            }
            else if (b > a && b > c)
            {
                Console.WriteLine(b);
            }

            else if (c > a && c > b)
            {
                Console.WriteLine(c);
            }
            else
            {
                Console.WriteLine("Error");
            }
        }
      
    }
}



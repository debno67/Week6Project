using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace evenOdd
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");

            int myNum = 4123;

            if (myNum % 2 == 0)
            {
                Console.WriteLine("even");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("odd");
                Console.ReadLine();

            }

        }
    }
}

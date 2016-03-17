using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doWhileLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            decimal.factorial = 1;
            do
            {

                if (n <= 1)
                {
                    break;

                }

                factorial *=n;
                n--;

            } while (true);

            Console.WriteLine("n! = " + factorial);
        }
    }
}


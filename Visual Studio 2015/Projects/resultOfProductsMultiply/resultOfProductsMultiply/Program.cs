using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace resultOfProductsMultiply
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            int m = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter another number: ");
            int n = int.Parse(Console.ReadLine());

            int product = 1;


            decimal factorial = 1;
            while (true)
            {
                if (m > n)
                { 
                    break;
            }
                product *= m;
                m++;
            }
            Console.WriteLine(product);
                  
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace continueInLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            //  int n = int.Parse(Console.ReadLine());
            //int sum = 0;
            //for (int i = 1; i <= n; i+=2)
            //{
            //  if (i % 7 == 0)
            // {
            //   continue;
            //}
            //sum += i;
            //}
            //Console.WriteLine("sum = "+sum);



            Console.WriteLine("Enter a starting number");
            int n = int.Parse(Console.ReadLine());
            if (n % 2 != 0)
            {
                Console.WriteLine("Do Better");
            }
            else
            {

                Console.WriteLine("Enter an even ending number");
                int m = int.Parse(Console.ReadLine());
                int sum = m;
                for (int i = 1; i <= n; i += 2)
                {
                    if (m % 2 != 0)
                    {
                        continue;
                    }
                    sum += i;
                }
                Console.WriteLine("sum = " + sum);
            }




        }
    }
}

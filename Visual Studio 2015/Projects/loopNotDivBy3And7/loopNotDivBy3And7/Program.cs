using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loopNotDivBy3And7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number greater than 1");
            int userInput = int.Parse(Console.ReadLine());
            for(int counter = 1; counter <= userInput; counter++)
            {
                if ((counter % 3 == 0) && (counter % 7 == 0))
                {
                    continue;
                }
                else
                {

                    Console.WriteLine(counter);
                }
            }
        }
    }
}

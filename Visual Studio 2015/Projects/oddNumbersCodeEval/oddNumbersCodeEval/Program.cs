using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oddNumbersCodeEval
{
    class Program
    {
        static void Main(string[] args)
        {
            int oddNums;

            for(oddNums = 1; oddNums <= 99; oddNums++)
            {
                if (oddNums % 2 != 0)
                    Console.WriteLine(oddNums);
            }
                    
        }
    }
}

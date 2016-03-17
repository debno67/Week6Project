using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multiplicationTable
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;

            for (int row = 1; row <= 5; row++)
            {
                for (int col = 1; col <= 5; col++)
                {
                    sum = row * col;

                    Console.Write(sum);
                }
                Console.WriteLine( );
                      
            }
        }
    }
                     
}
        
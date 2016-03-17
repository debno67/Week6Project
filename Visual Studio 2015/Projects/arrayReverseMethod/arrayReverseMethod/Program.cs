using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrayReverseMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 2, 5, 9, 4, 3, 4, 6, 5 };
            Array.Reverse(numbers);
            Console.WriteLine(numbers[0]);


            char[] alphaChar = { 'a', 'b', 'c', 'd', 'e', 'f' };
            Console.WriteLine(alphaChar[0]);
            Array.Reverse(alphaChar);
            Console.WriteLine(alphaChar[0]);
        }
    }
}

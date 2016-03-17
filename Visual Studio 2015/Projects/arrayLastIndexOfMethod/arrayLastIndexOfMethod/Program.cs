using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrayLastIndexOfMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            //  int[] numbers = { 2, 5, 9, 4, 3, 4, 6, 5 };
            //  Console.WriteLine(Array.LastIndexOf(numbers, 4));


            // int[] luckyNumbers = { 4, 10, 8, 30, 4, 10, 8, 30 };
            // Console.WriteLine(Array.LastIndexOf(luckyNumbers, 10));

            int[] nums = new int[] { 25, 36, 45, 36, 23 };
            int total = 0;
            
            foreach(int num in nums)
            {
                total += num;
            }
            Console.WriteLine(total);
        }
    }
}

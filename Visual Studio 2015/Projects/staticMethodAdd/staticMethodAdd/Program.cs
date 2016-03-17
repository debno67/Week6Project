using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace staticMethodAdd
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");
            int number1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter a number:");
            int number2 = int.Parse(Console.ReadLine());

            int numbers = Add(number1, number2);
            Console.WriteLine(numbers);
        }

        static int Add(int number1, int number2)
        {
            int sum = number1 + number2;
            return sum;
        }

    }

}

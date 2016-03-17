using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = "2 7 15";  //simulating codeeval input, do not copy
            string[] arrayOfNumbers = line.Split();  //splitting string line into an array that holds each number(still as a string)
            int fizz = int.Parse(arrayOfNumbers[0]);  //fizz number
            int buzz = int.Parse(arrayOfNumbers[1]);  //buzz number
            int limit = int.Parse(arrayOfNumbers[2]);  //how high we count

            for(int counter = 1; counter <= limit; counter++)
            {
                if (counter % fizz == 0 && counter % buzz == 0)
                    Console.Write("FB ");

                else if (counter % fizz == 0)
                    Console.Write("F ");

                else if (counter % buzz == 0)
                    Console.Write("B ");

                else

                    Console.Write(counter + " ");


            }
            
        }
    }
}

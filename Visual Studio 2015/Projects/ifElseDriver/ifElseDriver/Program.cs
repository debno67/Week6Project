using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ifElseDriver
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What's your age?");  //Asking for age

            int userAge = int.Parse(Console.ReadLine()); //initializing and assigning variable, parse string to int, print user input

            if (userAge >= 16)  //conditional statement

                Console.WriteLine("You can drive.");  //console output

            else
            {
                if (userAge >= 18)  //conditional statement

                    Console.WriteLine("You are an adult.");  //console output

                else

                if (userAge < 18)  //conditional statement

                    Console.WriteLine("You're not an adult."); //console output
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace userLastNameA
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ask for user name
            Console.WriteLine("What's your name?");
            //declare a string and initialize
            string studentName = Console.ReadLine();
            //Find index of first letter
            if (studentName[0] == 'A')
            {
                //If name begins with A, send to front of line
                Console.WriteLine("Go to front of the line.");
            }
            //If last name does not equal A, stay where they are at
        }
    }
}

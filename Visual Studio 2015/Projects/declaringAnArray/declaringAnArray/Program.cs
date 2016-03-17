using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace declaringAnArray
{
    class Program
    {
        static void Main(string[] args)
        {
            // int[] myArray = new int[6];
            // Console.WriteLine("Enter a number.");
            // myArray[0] = int.Parse(Console.ReadLine());


            //assign string array named days (prefilled with values
            string[] days = { "Mon", "Tues", "Wed", "Thurs", "Fri", "Sat" };

            //declaration int arry, knew the size, but not value
            int[] studentAge = new int[5];

            //Prompting user
            Console.WriteLine("Enter age:");

                studentAge[0] = int.Parse(Console.ReadLine());
                studentAge[1] = int.Parse(Console.ReadLine());
                studentAge[2] = int.Parse(Console.ReadLine());

            Console.WriteLine(studentAge.Length);


            //
            char[] lastName = { 'N','o','l','a','n' };
            Console.WriteLine(lastName.Length);

            string[] randomWords = { "copper", "potato", "button", "switch", "zoo" };
            Console.WriteLine(randomWords[randomWords.Length -2]);


        }
    }
}

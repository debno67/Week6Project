using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nestedLoopsAgeMovie
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What age are you?");
            int userAge = int.Parse(Console.ReadLine());

            if (userAge > 17)
            {
                Console.WriteLine("Come on in.");

                if (userAge >= 65)

                    Console.WriteLine("You get a discount.");
            }
            else
                Console.WriteLine("Your too young to see this movie.");


        }
    }
}

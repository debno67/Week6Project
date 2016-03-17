using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conditionalStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            //  int x = 4;
            //  int y = 3;

            //   if (x > y)
            //  {
            //     Console.WriteLine("{0} is greater than {1}", x, y);

            //     if (true)
            //    {
            //       Console.WriteLine(true);
            //    }
            //    else
            //    {
            //       Console.WriteLine(false);
            //

            Console.WriteLine("How old are you?");
            {
                int userAge = int.Parse(Console.ReadLine());

                if (userAge < 17)
                {
                    Console.WriteLine("You are too young for the movie.");
                }
                else

                    Console.WriteLine("Please enter.");
                {

                }
            }
        }
    }   
}


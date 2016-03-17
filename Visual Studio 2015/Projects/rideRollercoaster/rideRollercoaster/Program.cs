using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rideRollercoaster
{
    class Program
    {
        static void Main(string[] args)
        {

            //ask for age
            Console.WriteLine("What's your age?");
            int age = int.Parse(Console.ReadLine());
            //askfor height
            Console.WriteLine("What is your height in feet?");
            //convert age(string) to int
            double height = double.Parse(Console.ReadLine());
            //convert height(string) to int
            //if >= 18, can ride
            if (height >= 5.0 && age >= 18)
            {
                Console.WriteLine("Enjoy your ride!");
            }
            //if >= 5.0 feet can ride
            else (Console.WriteLine("Please pick another ride."));
            { 
            //else too young
        }
    }
}

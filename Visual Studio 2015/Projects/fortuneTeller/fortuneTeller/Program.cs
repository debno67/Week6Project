using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fortuneTeller
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your first name: ");
            Console.ReadLine();
            Console.WriteLine("Enter your last name: ");
            Console.ReadLine();
            Console.WriteLine("Enter your age: ");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("What month were you born?");
            Console.ReadLine();
            Console.WriteLine("Please enter your favorite ROYGBIV color: ");
            //if user does not know what ROYGBIV is, ask them to enter "Help"
            //create a list of ROYGBIV colors
            Console.WriteLine("How many siblings do you have? ");
            Console.ReadLine();

            string fName;
            string lName;
            string birthMonth;
            string ROYGBIV;
            string[] help = { "red", "orange", "yellow", "green", "blue", "indigo", "violet" };
            int numOfSibs;

            if(age % 3 == 0)
            {
                Console.WriteLine("")



                    //user first name
                Console.WriteLine("Enter your first name:");
               // Console.ReadLine();
                string firstName = Console.ReadLine();

                //user last name
                Console.WriteLine("Enter your last name:");
                //Console.ReadLine();
                string lastName = Console.ReadLine();

                //user age
                Console.WriteLine("Enter your age:");
                    int userAge = int.Parse(Console.ReadLine());

                //user birth month
                Console.WriteLine("Enter the month you were born:");
                string birthMonth = Console.ReadLine();

                //user favorite ROYGBIV
                Console.WriteLine("What is your favorite ROYGBIV?");
                Console.WriteLine("Enter" + "Help" + "to see a list");
                string favoriteColor = Console.ReadLine()
                    string[] help = { red, orange, yellow, green, blue, indigo, violet }; 
                    //help option that lists ROYGBIV colors
                    //number of siblings
                    //determine if age is odd or even
                    //retirement year for odd age, retirement year for even year
                    //0 siblings = location1
                    //1 sibling = location2
                    //2 siblings = location3
                    //3 siblings = location4
                    //over 3 siblings = location 5
                    //7 modes of transportation
                    //if first letter of birth month is located in first or last name = bank account total
                    //second letter of birth month = amount in bank
                    //third letter of birth month = amount in bank

            Console.WriteLine([First Name] [Last Name] will retire in [# of years] with [Amount of money in bank],
            a vacation home in [Location] and a [Mode of Transportation].)

            Console.WriteLine("Would you like to try again?");
            Console.ReadLine();
            //answer yes, program starts over
            //answer no, program ends
            


        

    }
}

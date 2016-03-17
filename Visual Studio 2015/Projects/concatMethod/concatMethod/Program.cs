using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace concatMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            string greeting = "Howdy";

            string name = "User";

            Console.WriteLine(greeting + " " + name);

            Console.WriteLine(string.Concat(greeting, " ", name));


            string firstName = "John";
            string lastName = "Smith";
            string fullName = string.Concat(firstName, " ", lastName);

            int age = 28;
            string nameAndAge = "Name: " + fullName + "\nAge: " + age;

            Console.WriteLine(nameAndAge);
        }
    }
}

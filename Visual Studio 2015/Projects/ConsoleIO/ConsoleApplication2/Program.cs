
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleIO

{
    class Program
    {
        static void Main(string[] args)  //entry point of program
        {  //body of program - says do something

            //writeline is a method of the console type
            //intialized int x = value of 20
            //console.writeline((x % 35 == 0));  false because there is not a remainder of 0
            // Console.WriteLine("We Can Code It");
            // Console.Write("Coding ");
            //Console.Write("Bootcamp");


            // Console.WriteLine("First Name:");
            //string firstName = Console.ReadLine();
            //Console.WriteLine("Last Name:");
            //string lastName = Console.ReadLine();
            //Console.WriteLine("Age:");
            //int age = int.Parse(Console.ReadLine());
            //Console.WriteLine("Gender:");
            //string gender = Console.ReadLine();
            //Console.WriteLine("House Number:");
            //int num = int.Parse(Console.ReadLine());
            //Console.WriteLine("Street:");
            //string street = Console.ReadLine();
            //Console.WriteLine("City");
            //string city = Console.ReadLine();
            //Console.WriteLine("State");
            //string state = Console.ReadLine();
            //Console.WriteLine("Zip");
            //int zip = int.Parse(Console.ReadLine());
            //Console.ReadLine(firstName + " " + lastName);

            System.Console.Write("What is your Name?");
            string name = System.Console.ReadLine();
            System.Console.WriteLine("What is your age?");
            int age = int.Parse(System.Console.ReadLine());
            System.Console.WriteLine(name);
            System.Console.WriteLine(age);
            





        }
    }
}

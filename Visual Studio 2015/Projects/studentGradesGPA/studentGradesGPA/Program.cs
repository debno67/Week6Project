using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studentGradesGPA
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter student's name:");
            string studentName = Console.ReadLine();

            string[] letterGrade = new string[5];

            Console.WriteLine("Enter your grade for Math:");
            letterGrade[1] = Console.ReadLine();
            Console.WriteLine("Enter your grade for Science:");
            letterGrade[2] = Console.ReadLine();
            Console.WriteLine("Enter your grade for Reading:");
            letterGrade[3] = Console.ReadLine();
            Console.WriteLine("Enter your grade for Art:");
            letterGrade[4] = Console.ReadLine();
            Console.WriteLine("Enter your grade for History:");
            letterGrade[5] = Console.ReadLine();

            


        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace likeArrayOfChars
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name");
            string name = Console.ReadLine();

            for (int i = 0; i <name.Length ; i++)
            {
                Console.WriteLine(name[i]);
            }
        }
    }
}

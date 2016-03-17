using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loopsOverCharInName
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name:");
            string name = Console.ReadLine();
            int length = name.Length;
            for(int i = 0; i < length; i++)
            {
                Console.WriteLine(name[i]);
            }
            
        }
    }
}

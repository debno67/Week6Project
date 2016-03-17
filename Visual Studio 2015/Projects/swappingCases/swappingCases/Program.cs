using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace swappingCases
{
    class Program
    {
        static void Main(string[] args)
        {
            string laughing = "lol!";
            string goodbye = "l8r";

            Console.WriteLine(laughing.ToUpper());
            Console.WriteLine(goodbye.ToUpper());

            string mixed = "HelLO";
            Console.WriteLine(mixed.ToLower());
        }
    }
}

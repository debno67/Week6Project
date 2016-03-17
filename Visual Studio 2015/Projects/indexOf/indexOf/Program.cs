using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace indexOf
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] birthMonths = { "October", "July", "October", "May" };
            Console.WriteLine(Array.IndexOf(birthMonths, "October"));


            string[] firstNames = { "Debbie", "Mary", "Seron", "Doug" };
            Console.WriteLine(Array.IndexOf(firstNames, "Mary"));
        }
    }
}

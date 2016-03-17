using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace toString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(9.ToString());

            double pi = 3.14;

            Console.WriteLine(pi.ToString());

            bool ownsCar = true;

            Console.WriteLine(ownsCar.ToString());

            DateTime today = DateTime.Now;

            Console.WriteLine(today.ToString());
        }
    }
}

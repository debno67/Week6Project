using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace removeMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            //Remove "IT" from string

            string myStr = "We Can Code IT";

            string it = myStr.Remove(12, 2);

            Console.WriteLine(it);

            Console.WriteLine("myStr");

            //note:  the original "myStr" was never changed.
        }
    }
}

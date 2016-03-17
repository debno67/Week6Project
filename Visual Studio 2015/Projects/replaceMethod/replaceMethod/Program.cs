using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace replaceMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            string
                myString = "We Can Code It";
            string result = myString.Replace("We", "I");
            Console.WriteLine(result);
        }

    }
}

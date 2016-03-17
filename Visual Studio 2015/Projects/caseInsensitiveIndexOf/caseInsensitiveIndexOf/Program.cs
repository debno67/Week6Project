using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caseInsensitiveIndexOf
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "We Can Code IT";

            string nameUp = name.ToUpper();

            int index = nameUp.IndexOf("CAN");

            Console.WriteLine(index);

            index = name.IndexOf("CAN");

            Console.WriteLine(index);
        }
    }
}

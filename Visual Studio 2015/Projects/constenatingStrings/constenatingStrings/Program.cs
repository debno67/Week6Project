using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constenatingStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder name = new StringBuilder();

            for (int i = 0; i<100; i++)
            {
                name.Append(i);
            }

            Console.WriteLine(name.ToString());
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stringBuilderStandardJoin
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now);

            string numStr = "";
            numStr += "Build with concatenation.";

            for (int i = 0; i < 200000; i++)
            {
                numStr += i;
            }

            Console.WriteLine(DateTime.Now);
        }
    }
}

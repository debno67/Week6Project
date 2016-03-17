using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dataType.Parse
{
    class Program
    {
        static void Main(string[] args)
        { 
            string pi = "3.14";

            double p = double.Parse(pi);

            string ownsCar = "true";

            bool hasCar = bool.Parse(ownsCar);

            string pastDate = "10/31/14";

            DateTime halloween = DateTime.Parse(pastDate);

            Console.WriteLine(hasCar);
        }
    }
}

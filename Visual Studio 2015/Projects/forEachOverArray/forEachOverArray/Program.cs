using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forEachOverArray
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] food = { "pizza", "cake", "grapes" };

            foreach(string foodItem in food)

            {
                Console.WriteLine("I love " + foodItem);
            }
        }
    }
}

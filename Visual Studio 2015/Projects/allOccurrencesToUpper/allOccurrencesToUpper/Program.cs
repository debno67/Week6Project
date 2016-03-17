using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace allOccurrencesToUpper
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "Hello world!  I like to" + "say hello to all of my friends.";

            str = str.ToUpper();

            string search = "HELLO";
            int position = str.IndexOf(search);
            while(position != -1)
            {
                Console.WriteLine(search + " found at" + position);
                position = str.IndexOf(search, position + 1);
            }
        }
    }
}

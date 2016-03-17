using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace removeCodeFromString
{
    class Program
    {
        static void Main(string[] args)
        {
            string myStr = "We Can {Code} IT";        //initializing a string, assigning a value
            int openCurlLoc = myStr.IndexOf("{");     
            int closeCurlLoc = myStr.IndexOf("}");
            int lenStr = closeCurlLoc + 1 - openCurlLoc;

            //string result = myStr.Remove(openCurlLoc, lenStr);
            string result = myStr.Remove(openCurlLoc, 1);
            Console.WriteLine(myStr);
            Console.WriteLine(result);
            closeCurlLoc -= 1;
            //Console.WriteLine(result);
            Console.WriteLine(result.Remove(closeCurlLoc, 1));
        }
    }
}

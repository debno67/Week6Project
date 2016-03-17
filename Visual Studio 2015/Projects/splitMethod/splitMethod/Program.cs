using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace splitMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            string myStr = "We, Can, {Code}, IT";
            char[] separators = new char[] { ',', ' ' };
            string[] splitString = myStr.Split(separators, StringSplitOptions.RemoveEmptyEntries);

            foreach(string item in splitString)
            {
                Console.WriteLine(item);
            }
        }
    }
}

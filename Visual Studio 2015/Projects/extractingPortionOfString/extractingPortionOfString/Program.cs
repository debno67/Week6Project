using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace extractingPortionOfString
{
    class Program
    {
        static void Main(string[] args)
        {
            //string myStr = "We Can Code IT";

            //string code = myStr.Substring(7, 4);

            //Console.WriteLine(myStr);

            //Console.WriteLine(code);


            string path = "C:\\Docs\\MyImage.jpg";
            int index = path.LastIndexOf("\\");

            //index = 7

            string justName = path.Substring(index + 1);
            Console.WriteLine(justName);

            //justName= "MyImage.jpg"

        }
    }
}

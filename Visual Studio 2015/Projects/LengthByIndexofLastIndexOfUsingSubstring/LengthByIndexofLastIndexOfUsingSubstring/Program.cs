using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LengthByIndexofLastIndexOfUsingSubstring
{
    class Program
    {
        static void Main(string[] args)
        {
            //return only "MyImage"

            string path = "C\\Docs\\MyImage.jpg";
            int sIndex = path.LastIndexOf("\\");  //index = 7
            sIndex = sIndex + 1;  //index = 8.  Get from backslash to "M"
            int dIndex = path.LastIndexOf(".");  //index = 15
            int len = dIndex - sIndex;  //length = 7 (15 - 8)

            string justName = path.Substring(sIndex, len);
            Console.WriteLine(justName);


            //justName = "MyImage"
        }
    }
}
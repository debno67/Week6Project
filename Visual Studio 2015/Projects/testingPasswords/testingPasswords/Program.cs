using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testingPasswords
{
    class Program
    {
        static void Main(string[] args)
        {
            string pass1 = "PAssWord";
            string pass2 = "passWord";
            string pass3 = "PAssWORD";

            if(pass1.ToUpper()=="PASSWORD" && pass2.ToUpper() == "PASSWORD" && pass3.ToUpper() == "PASSWORD")
            {
                Console.WriteLine("all is well, Go forth");
            }
        }
    }
}

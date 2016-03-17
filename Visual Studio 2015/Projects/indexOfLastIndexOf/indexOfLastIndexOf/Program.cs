using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace indexOfLastIndexOf
{
    class Program
    {
        static void Main(string[] args)
        {
            // string name = "We Can Code IT";

            //int index = name.IndexOf("Code");

            //Console.Write(index);




            string str = "C# is fun!";

            //variation.  use a comma to include a second argument that states
            //where to start searching

            int index = str.IndexOf("C#", 5);  //0
            Console.WriteLine(index);

            index = str.LastIndexOf("fun");  //6
            Console.WriteLine(index);

            index = str.LastIndexOf("IS", 9);  //-1
            Console.WriteLine(index);

            index = str.LastIndexOf("is f");  //3
            Console.WriteLine(index);

            index = str.LastIndexOf("!");  //9
            Console.WriteLine(index);

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trim
{
    class Program
    {
        static void Main(string[] args) 
        {
            string fileData = " 111 $ % David  Allen ### s  ";
             
            char[] trimChars = new char[] { ' ', '1', '$', '%', '#', 's' };

            string reduced = fileData.Trim(trimChars);

            Console.WriteLine(reduced);
        }
    }
}

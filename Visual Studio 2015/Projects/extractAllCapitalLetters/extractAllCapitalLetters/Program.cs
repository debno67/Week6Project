using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace extractAllCapitalLetters
{
    class Program
    {
        static void Main()
        {
            string text = "EM edit";
            string reversed = ReverseText(text);
            Console.WriteLine(reversed);
            string caps = ExtractCapitals(text);
            Console.WriteLine(caps);

            //console output
        }
       public static string ExtractCapitals(string str)//a method called ExtractCapitals
        {
            StringBuilder result = new StringBuilder();  //creating
            for (int i = 0; i <  str.Length; i++)  //setting up loop, starts at the end, counts backwards
            {
                char ch = str[i];
                if (char.IsUpper(ch))
                {
                    result.Append(ch);
                }
            }
            return result.ToString();              

        }
    }
}

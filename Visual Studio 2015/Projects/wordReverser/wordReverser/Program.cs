using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wordReverser
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "EM edit";
            string reversed = ReverseText(text);
            Console.WriteLine(reversed);

            //console output
        }
            static string ReverseText(string text)
            {
            StringBuilder sb = new StringBuilder();  //creating stringbuilder object called sb
            for(int i = text.Length -1; i >= 0; i--)  //setting up loop, starts at the end, counts backwards
            {
                sb.Append(text[i]);  //rewriting string text in reversed order
            }
            return sb.ToString();  //returning result to the Main, result returned to reversed
            
        }
    }
}

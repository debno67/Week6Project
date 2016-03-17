using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace penultimateCodeEval
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = "some line with text";
            string[] words = line.Split();
            Console.WriteLine(words[words.Length -2]);
          
        }
    }
}

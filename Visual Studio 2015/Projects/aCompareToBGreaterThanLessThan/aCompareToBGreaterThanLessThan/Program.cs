using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aCompareToBGreaterThanLessThan
{
    class Program
    {
        static void Main(string[] args)
        {
            // 
            //Console.WriteLine( "a".CompareTo("b");

            //
            //Console.WriteLine("b".CompareTo("a");





            // Console.WriteLine("a".CompareTo("A"));
            //Console.WriteLine("dog".CompareTo("Dog"));


           // string name = "Jen";
            //string name2 = "Joe";
            //Console.WriteLine(name.CompareTo(name2)); //vs. "Jen".

            //IGNORE CASE

                Console.WriteLine(string.Compare("A", "a", false));

                Console.WriteLine(string.Compare("A", "a", true));

                Console.WriteLine(string.Compare("A", "1"));

           


            
        }
    }
}

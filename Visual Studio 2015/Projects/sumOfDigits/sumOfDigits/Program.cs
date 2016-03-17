using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sumOfDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = "23";
            //declaring a string named line = to 23
            char[] linearr = line.ToCharArray();  //using char array to convert string to char
            int sum = 0;  //initializing int caled sum, equal to 0 (placeholder)

            for (int index = 0; index < linearr.Length; index++)
            {  //use for loop, start the index at 0, index is less than the length of line array, adding 1 to index
                sum = sum += int.Parse((linearr[index].ToString()));
            } //converting parsed sum back to string
            Console.WriteLine(sum);
            //printing answer to console
        }
    }
}

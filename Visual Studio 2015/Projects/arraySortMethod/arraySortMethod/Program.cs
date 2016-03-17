using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arraySortMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] numbers = { 2, 5, 9, 4, 3, 4, 6, 5 };
            //Array.Sort(numbers);
            //Console.WriteLine(numbers[0]);
            //Console.WriteLine(numbers[1]);
            //Console.WriteLine(numbers[2]);



            //string[] studentNames = { "Suron One", "Deb Two", "Mary Three", "Jackie Four" };
            //Array.Sort(studentNames);
            //Console.WriteLine(studentNames[studentNames.Length -1]);


            int[] favNum = { 10, 18, 16, 14, 12 };
            Array.Sort(favNum);
            Console.WriteLine(favNum[0]);
            Console.WriteLine(favNum[favNum.Length -1]);

        }

    }
}

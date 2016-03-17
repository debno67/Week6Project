using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            double myRecArea = GetRectangleArea(3.5, 9.9);
            Console.WriteLine(myRecArea);
        }


        static double GetRectangleArea(double width, double height)
        {
            double area = width * height;
            return area;
        }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] days = { "Mon", "Tue", "Wed", "Thur", "Fri", "Sat", "Sun" };

            //int i;

            //for (i = 0; i < days.Length; i++)
            //{
            //    Console.WriteLine(days[i]);

            //}


















                string[] months = { "Jan", "Feb", "Mar", "April", "May", "Jun" };
                Array.Sort(months);

                int i;

                for (i = 0; i < months.Length; i++)
                {
                    Console.WriteLine(months[i]);
                }
            
            
        }
    }
}

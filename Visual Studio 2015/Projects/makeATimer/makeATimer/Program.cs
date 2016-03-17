using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace makeATimer
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int hour = 1; hour <= 12; hour++)
            {
                for(int min = 1; min <60; min++)
                {
                    for(int sec = 1; sec <60; sec++)
                    {
                        for (int ms = 1; ms <= 1000; ms++)
                        {
                            Console.WriteLine(hour + ":" + min + ":" + sec + ":" + ms);
                            System.Threading.Thread.Sleep(1000);
                        }

                    }
                }
            }
        }
    }
}

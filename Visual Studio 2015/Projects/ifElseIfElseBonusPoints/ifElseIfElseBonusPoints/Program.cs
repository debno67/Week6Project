using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ifElseIfElseBonusPoints
{
    class Program
    {
        static void Main(string[] args) {


            Console.WriteLine("Please enter your score between 1 and 9");


            int score = int.Parse(Console.ReadLine());
            int bonus = 0;

            if (score >= 1 && score <= 3)
            {
                bonus = score * 10;
            }
            else if (score >= 4 && score <= 6)
            { 
                bonus = score * 100;
            }
            else if (score >= 7 && score >= 9)
            {

                bonus = score * 1000;
            }

            else
            {

                bonus = 0;
                score = 0;

                Console.WriteLine("You scored (score).");

                Console.WriteLine("You received a bonus of (bonus)");


            }

           

        }
    }
}

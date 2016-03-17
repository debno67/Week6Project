using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace randomPhraseMagic8Ball
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] responses = { "You win the lottery", "Going home early", "Learn C#" };
            var max = responses.Length;
            Random random = new Random();
            var selectedNum = random.Next(max);
            Console.WriteLine(responses[selectedNum]);
            Console.WriteLine("Would you like to play again?");
            string answer = "N";
            string[] responses

            do

                if (answer == "no")
                {
                    break;
                }

            while (answer == "yes");
            {
                Console.WriteLine("Play again!");
            }
    
                
            
        }
    }
}

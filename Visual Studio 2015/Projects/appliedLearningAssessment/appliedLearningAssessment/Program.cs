﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appliedLearningAssessment
{
    class Program
    {
        static void Main(string[] args)
        {

            // PROBLEM 1:

            //Console.Writeline("Please enter a number:");
            //int num = int.Parse(Console.Readline());

            //if (num < 10)
            //{
            //    Console.Writeline("This number is too small!");
            //}

            //else if (num >= 10)
            //{
            //    Console.Writeline("This number is big enough.");

            //PROBLEM 2:

            //float[] myNums = new float[5];

            //myNums[0] = 1.0f;
            //myNums[1] = 2.2f;
            //myNums[2] = 3.5f;
            //myNums[3] = 4.2f;
            //myNums[4] = 5.8f;

            //Console.WriteLine(myNums[1]);

            //PROBLEM 3:

            //float[] myNums = new float[5];

            //myNums[0] = 1.0f;
            //myNums[1] = 2.2f;
            //myNums[2] = 3.5f;
            //myNums[3] = 4.2f;
            //myNums[4] = 5.8f;

            //foreach (float m in myNums)
            //{
            //    Console.Write(m + "," + " ");
            //}


            //PROBLEM 4:
            
            Console.WriteLine("Enter a number");
            int i = int.Parse(Console.ReadLine());
            

            switch (i)
            {
                case 1:

                    Console.WriteLine("Only one?");
                    break;

                case 100:

                    Console.WriteLine("100?  That's a lot!");
                    break;

                default:

                    Console.WriteLine("Input not recognized.");
                    break;
            }
                 
        }
    }
}

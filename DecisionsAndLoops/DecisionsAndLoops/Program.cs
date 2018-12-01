﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecisionsAndLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            int score;
            Console.WriteLine($"Enter your score");
            string scoreAsText = Console.ReadLine();
            score = Convert.ToInt16(scoreAsText);
            if (score == 100)
            {
                // What is is in here, only gets executed 
                //once the condition is met.
                Console.WriteLine("Perfect score! You win");

            }
            if (score >= 90)
            {
                Console.WriteLine("You got an A");
            }
            else if (score >=80)
            {
                Console.WriteLine("You got an B");
            }
            else if (score >= 70)
            {
                Console.WriteLine("You got an C");
            }
            else if (score >= 60)
            {
                Console.WriteLine("You got an D");
            }
            else
            {
                Console.WriteLine("you DIE!");
            }
           
            // Everything here after if statement will still run.
            Console.ReadKey();
        }
    }
}

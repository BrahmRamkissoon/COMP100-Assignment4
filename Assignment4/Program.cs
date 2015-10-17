// Filename: Program.cs
// Author: Brahm Ramkissoon
// Created Date  (dd/mm/yyyy): 13/10/2015
// Description: Assignment 4 Part 1: Dice Rolling App
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    class Program
    {
        static void Main ( string [] args )
        {
            const int COUNT = 36000;   // number of times to roll dice

            Random randomRoll = new Random(); // random number generator

            int[] frequency = new int[13]; // store frequency of sums (2 to 12) , ignore index 0 and 1
     
            int diceOne = 0;    // stores random roll of dice # 1
            int diceTwo = 0;    // stores random roll of dice # 2
            int sumOfDie = 0;   // sum of both dice

            // summarize results of count rolls of a die
            for (int roll = 1; roll <= COUNT; ++roll)
            {
                diceOne = randomRoll.Next( 1, 7 ); // randomly get a number from 1 to 6
                diceTwo = randomRoll.Next( 1, 7 );
                sumOfDie = diceOne + diceTwo;


                ++frequency[sumOfDie];      // increment  frequency[2] to frequency[12]
            } // end for

            // output table headers
            Console.WriteLine( "Sum of Both Die \tFrequency"); 
            Console.WriteLine("+++++++++++++++++++++++++++++++++");


            // display number of times frequency[2] to frequency[12] have been incremented
            for (int count = 2; count < frequency.Length; ++count)
            {
                Console.WriteLine( $"\t{count}\t \t{frequency[count]}");
                
            } // end for

            // End of Program
            Console.WriteLine();
            Console.WriteLine("+++++++++++++++++++++++++++++++++");
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            Console.Clear();
        } // end main
    }
}

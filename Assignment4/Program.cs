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

            int[] frequency = new int[11]; // store frequency of possible sums, there are 12 possibilities
     
            int diceOne = 0;    // stores random roll of dice # 1
            int diceTwo = 0;    // stores random roll of dice # 2
            int sumOfDie = 0;   // sum of both dice

            // summarize results of count rolls of a die
            for ( int roll = 0 ; roll <= COUNT ; roll++ )
            {
                diceOne = 1 + randomRoll.Next(6); // randomly get a number from 1 to 6
                diceTwo = 1 + randomRoll.Next( 6 );
                sumOfDie = diceOne + diceTwo;

                // determine roll value 2-12 and increment appropriate counter
                switch ( sumOfDie )
                {
                    case 2:
                        frequency[0] += 1; // increment the 2s counter
                        break;
                    case 3:
                        frequency [1] += 1; // increment the 3s counter
                        break;
                    case 4:
                        frequency [2] += 1; // increment the 4s counter
                        break;
                    case 5:
                        frequency [3] += 1; // increment the 5s counter
                        break;
                    case 6:
                        frequency [4] += 1; // increment the 6s counter
                        break;
                    case 7:
                        frequency [5] += 1; // increment the 7s counter
                        break;
                    case 8:
                        frequency [6] += 1; // increment the 8s counter
                        break;
                    case 9:
                        frequency [7] += 1; // increment the 9s counter
                        break;
                    case 10:
                        frequency [8] += 1; // increment the 10s counter
                        break;
                    case 11:
                        frequency [9] += 1; // increment the 11s counter
                        break;
                    case 12:
                        frequency [10] += 1; // increment the 12s counter
                        break;
                    
                } // end switch
            } // end for
            Console.WriteLine( "Sum of Both Die \tFrequency"); // output headers
            Console.WriteLine("+++++++++++++++++++++++++++++++++");


            // display Results
            for (int count = 0; count < frequency.Length; count++)
            {
                int sumValue = frequency [count];
                Console.WriteLine( $"\t{count+2}\t \t{sumValue}");
                
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

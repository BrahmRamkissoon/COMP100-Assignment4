﻿// Filename: Program.cs
// Author: Brahm Ramkissoon
// Created Date  (dd/mm/yyyy): 14/10/2015
// Description: Assignment 4 Part 2: Airline reservations System
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part2
{
    class Program
    {
        static void Main ( string [] args )
        {
            const int MAX_SEATS_PER_SECTION = 5;
            const int MAX_SEATS = 10;

            int prompt = 0;                     // Sentinel value for menu
            bool [] seatChart = new bool [11];  // seating chart of plane, ignore 0 index
            int seatNum = 0;                    // subscript for seats[]
            string bookNextSection = "";        // accept user input if they need to book from another section
            int totalFirstClassSeatsBooked = 0; // count of seats booked in First Class
            int totalEconomySeatsBooked = 0;    // count of seats book in Economy 
            int totalSeatsBooked =
                totalEconomySeatsBooked
                + totalFirstClassSeatsBooked;   // count of seats booked in plane


            // Initialize all seats to false, empty
            for ( seatNum = 1 ; seatNum < seatChart.Length ; seatNum++ )
            {
                seatChart [seatNum] = false;
            }

            // Run Menu
            while ( prompt != 3 )
            {
                // Display menu
                Console.WriteLine("++++ Reservation App ++++");
                Console.WriteLine("+                       +");
                Console.WriteLine("+    1. First Class     +");
                Console.WriteLine("+    2. Economy         +");
                Console.WriteLine("+    3. Exit            +");
                Console.WriteLine("+                       +");
                Console.WriteLine("+++++++++++++++++++++++++");


                Console.WriteLine("++++++++++++++++++++++++++");
                Console.Write("Please choose an option above (1 -3): ");

                prompt = Convert.ToInt32(Console.ReadLine());

                // Get input for menu
                switch ( prompt )
                {
                    case 1:
                        // Check for empty seats in plane
                        if ( totalSeatsBooked != MAX_SEATS )
                        {
                            Console.WriteLine("\nChecking for available seats...");
                        }
                        else
                        {
                            Console.WriteLine("\nAll seats are booked");
                            Console.WriteLine("\nNext flight leaving in 3 hours");
                            break;
                        }

                        // iterate through first class seats
                        for ( seatNum = 1 ; seatNum <= 5 ; seatNum++ )
                        {
                            // if this seat is empty and booked first class seats are less than first class limit
                            if ( seatChart [seatNum] == false && totalFirstClassSeatsBooked <= MAX_SEATS_PER_SECTION )
                            {
                                Console.WriteLine("Empty seat found, press enter to continue booking...");
                                Console.ReadKey();
                                seatChart [seatNum] = true;
                                Console.WriteLine($"\nSeat Number: {seatNum} is booked");
                                totalFirstClassSeatsBooked++;
                                break;
                            }

                            if ( seatChart [seatNum] && totalFirstClassSeatsBooked == MAX_SEATS_PER_SECTION )
                            {
                                Console.WriteLine("\nAll First class seats are booked");
                                Console.WriteLine("");
                                Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++");
                                Console.WriteLine("\nWould you like to book an Economy seat? ");
                                Console.WriteLine("Press 1. Yes");
                                Console.WriteLine("Press 2. No ");
                                Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++");

                                bookNextSection = Console.ReadLine();

                                if ( bookNextSection == "Y" )
                                {
                                    goto case 2;
                                }
                                Console.WriteLine("Next flight leaving in 3 hours.");
                            } // end if
                        } // end for
                        PressKey();
                        break; // end case 1

                    case 2:
                        // Check for empty seats in plane
                        if ( totalSeatsBooked != MAX_SEATS )
                        {
                            Console.WriteLine("\nChecking for available seats...");
                        }
                        else
                        {
                            Console.WriteLine("\nAll seats are booked");
                            Console.WriteLine("\nNext flight leaving in 3 hours");
                            break;
                        }

                        // iterate through Economy seats
                        for ( seatNum = 6 ; seatNum <= 10 ; seatNum++ )
                        {
                            // if this seat is empty and booked first class seats are less than first class limit
                            if ( seatChart [seatNum] == false && totalEconomySeatsBooked <= MAX_SEATS_PER_SECTION )
                            {
                                Console.WriteLine("Empty seat found, press enter to continue booking...");
                                Console.ReadKey();
                                seatChart [seatNum] = true;
                                Console.WriteLine($"\nSeat Number: {seatNum} is booked");
                                totalEconomySeatsBooked++;
                                break;
                            }

                            if ( seatChart [seatNum] && totalEconomySeatsBooked == MAX_SEATS_PER_SECTION )
                            {
                                Console.WriteLine("\nAll economy seats are booked");
                                Console.WriteLine("");
                                Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++");
                                Console.WriteLine("\nWould you like to book a First Class seat? ");
                                Console.WriteLine("Press 1. Yes");
                                Console.WriteLine("Press 2. No ");
                                Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++");

                                bookNextSection = Console.ReadLine();

                                if ( bookNextSection == "Y" )
                                {
                                    goto case 1;
                                }
                                Console.WriteLine("Next flight leaving in 3 hours.");
                            } // end if
                        } // end for
                        PressKey();
                        break; // end case 2
                    case 3:
                        Console.WriteLine("\nThank you! See you soon!");
                        PressKey();
                        break;
                    default:
                        Console.WriteLine("Error");
                        break;
                } // end switch
            } // end while
        } // end main

        public static void PressKey ()
        {
            Console.WriteLine();
            Console.WriteLine("+++++++++++++++++++++");
            Console.WriteLine("Press any key to continue....");
            Console.ReadKey();
            Console.Clear();
        }
    }
}

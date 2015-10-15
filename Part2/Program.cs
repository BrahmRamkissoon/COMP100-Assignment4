// Filename: Program.cs
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
    internal class Program
    {
        private static void Main(string[] args)
        {
            const int FIRST_CLASS_SEAT_START = 0;
            const int FIRST_CLASS_SEAT_LIMIT = 4;
            const int ECONOMY_SEAT_START = 5;
            const int ECONOMY_CLASS_SEAT_LIMIT = 9;

            int prompt = 0; // Sentinel value for menu
            bool[] seats = new bool[10];    // seating chart of plane
            int available = 0;  // subscript for seats[]
            bool runCheck = true;
            int seatNumber = -1;    // -1 means not assigned



            // Initialize all seats to false
            for (int index = 0; index < seats.Length ; index++)
            {
                seats [index] = false;
            }

            while (prompt != 3)
            {
                // Display menu
                Console.WriteLine( "++++ Reservation App ++++" );
                Console.WriteLine( "+                       +" );
                Console.WriteLine( "+    1. First Class     +" );
                Console.WriteLine( "+    2. Economy         +" );
                Console.WriteLine( "+    3. Exit            +" );
                Console.WriteLine( "+                       +" );
                Console.WriteLine( "+++++++++++++++++++++++++" );


                Console.WriteLine( "++++++++++++++++++++++++++" );
                Console.Write( "Please choose and option above (1 -3): " );

                prompt = Convert.ToInt32( Console.ReadLine() );

                switch (prompt)
                {
                    case 1:
                        Console.WriteLine( "Checking for available seats..." );
                        while (runCheck)
                        {
                            if ( seats [available] == false 
                                && available >= FIRST_CLASS_SEAT_START 
                                && available <= FIRST_CLASS_SEAT_LIMIT )
                            {
                                seats [available] = true;
                                runCheck = false;
                                seatNumber = available + 1;
                                Console.WriteLine( $"A first class seat has been assigned: {seatNumber}" );
                            }
                            else
                            {
                                Console.WriteLine( "All first class seats are booked" );
                                runCheck = false;
                            }
                        }

                        PressKey();
                        break;
                    case 2:
                        while ( runCheck )
                        {
                            if ( seats [available] == false
                                && available >= ECONOMY_SEAT_START
                                && available <= ECONOMY_CLASS_SEAT_LIMIT )
                            {
                                seats [available] = true;
                                runCheck = false;
                                seatNumber = available + 1;
                                Console.WriteLine($"An economy class seat has been assigned: {seatNumber}");
                            }
                            else
                            {
                                Console.WriteLine("All economy class seats are booked");
                                runCheck = false;
                            }
                        }
                        PressKey();
                        break;
                    case 3:
                        Console.WriteLine( "Thank you! See you soon!" );
                        break;
                    default:
                        Console.WriteLine( "Error" );
                        break;
                } // end switch
            } // end while
        } // end main

        public static void CheckSeat()
        {
            
        }
        public static void PressKey()
        {
            Console.WriteLine();
            Console.WriteLine("+++++++++++++++++++++");
            Console.WriteLine("Press any key to continue....");
            Console.ReadKey();
            Console.Clear();
        }
    }
}

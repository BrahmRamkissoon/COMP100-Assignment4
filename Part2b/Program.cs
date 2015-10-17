using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part2b
{
    class Program
    {
        static void Main ( string [] args )
        {
            const int FIRST_CLASS_SEAT_START = 1;
            const int FIRST_CLASS_SEAT_LIMIT = 5;
            const int ECONOMY_SEAT_START = 6;
            const int ECONOMY_CLASS_SEAT_LIMIT = 10;

            const int MAX_SEATS_PER_SECTION = 5;
            const int MAX_SEATS = 10;

            int prompt = 0; // Sentinel value for menu
            bool [] seatChart = new bool [11];    // seating chart of plane, ignore 0 index
            int seatNum = 1;  // subscript for seats[]
            string bookNextSection = "";


            int totalFirstClassSeatsBooked = 0;
            int totalEconomyClassSeatsBooked = 0;
            int totalSeatsBooked = totalEconomyClassSeatsBooked + totalFirstClassSeatsBooked;

            bool seatBooked = false;


            // Initialize all seats to false, empty
            for ( int index = 1 ; index < seatChart.Length ; index++ )
            {
                seatChart [index] = false;
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
                            if ( seatChart [seatNum] == false && totalFirstClassSeatsBooked <= FIRST_CLASS_SEAT_LIMIT )
                            {
                                Console.WriteLine("Empty seat found, press enter to continue booking...");
                                Console.ReadKey();
                                seatChart [seatNum] = true;
                                Console.WriteLine($"\nSeat Number: {seatNum} is booked");
                                totalFirstClassSeatsBooked++;
                                break;
                            }

                            if ( seatChart [seatNum] && totalFirstClassSeatsBooked == FIRST_CLASS_SEAT_LIMIT)
                            {
                                Console.WriteLine( "\nAll first class seats are booked" );
                                Console.WriteLine( "" );
                                Console.WriteLine( "++++++++++++++++++++++++++++++++++++++++++" );
                                Console.WriteLine( "\nWould you like to book an Economy seat? " );
                                Console.WriteLine( "Press 1. Yes");
                                Console.WriteLine( "Press 2. No ");
                                Console.WriteLine( "++++++++++++++++++++++++++++++++++++++++++" );
                                
                                bookNextSection = Console.ReadLine();

                                if (bookNextSection == "Y")
                                {
                                    goto case 2;
                                }
                                Console.WriteLine( "Next flight leaving in 3 hours." );
                            } // end if
                        } // end for
                    break; // end case 1

                    case 2:/*
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

                        Console.WriteLine("\nChecking for available seats...");

                        while ( prompt == 2 )
                        {
                            if ( seatChart [seatNum] == false
                                && seatNum >= ECONOMY_SEAT_START
                                && seatNum <= ECONOMY_CLASS_SEAT_LIMIT )
                            {
                                seatChart [seatNum] = true;

                                Console.WriteLine($"\nAn economy class seat has been assigned: {bookedSeat}");
                            }
                            else
                            {
                                Console.WriteLine("\nAll economy class seats are booked");
                                Console.WriteLine("\nWould you like to book a First Class seat? (Press Y or N): ");
                                bookNextSection = Console.ReadLine();
                                if ( bookNextSection == "Y" )
                                {
                                    prompt = 1;
                                }
                                else
                                {
                                    Console.WriteLine("Next flight leaving in 3 hours.");
                                }
                            }
                        }

                        PressKey();
                        break; */
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

        public static void CheckSeat ()
        {

        }
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

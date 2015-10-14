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
            int prompt = 0; // Sentinel value for menu

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
                        Console.WriteLine( "" );
                        //PressKey();
                        Console.Clear();
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    default:
                        Console.WriteLine( "Error" );
                        break;
                }
            }
        }
    }
}

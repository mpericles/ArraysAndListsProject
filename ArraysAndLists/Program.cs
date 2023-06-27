using System;
using System.Collections.Generic;
using System.ComponentModel.Design;

namespace ArraysAndLists
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO:

            // Create an int Array and populate numbers 1-10
            int[] myArray = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            /* Create two Lists of type int.
             * Name one List "evens"
             * Name the other List "odds"
             */

            //List<int> myevenlist = new List<int>() { 2, 4, 6, 8, 10 };
            //List<int> myoddlist = new List<int>() { 1, 3, 5, 7, 9 };
            //var evens = new List<int>();
            //var odds = new List<int>();

            List<int> evens = new List<int>() { };
            List<int> odds = new List<int>() { };

            /* Using either a foreach or for loop,
             * nest an if statement to check to see
             *  if a number is even or odd.
             * Then add those numbers to either the evens List
             * or the odds List
             */
            foreach (int  item in myArray)
            {
              if (item % 2 == 0)
                        {
                    evens.Add(item);
                }
              else
                {
                    odds.Add(item);
                }
            }

            Console.WriteLine("This is the even List");
            foreach (int item in evens)
            {
                
                Console.WriteLine(item);
            }

            Console.WriteLine("");
            Console.WriteLine("This is the odd List");
            foreach (int item in odds)
            {
                Console.WriteLine(item);
            }

            /* Now using foreach or for loops,
             * display each List of even and odd numbers
             *
             * Try to be creative in your display
             */
        }
    }
}

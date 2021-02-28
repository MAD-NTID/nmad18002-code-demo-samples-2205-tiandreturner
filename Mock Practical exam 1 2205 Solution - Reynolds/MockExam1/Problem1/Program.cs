using System;

namespace Problem1 {
    class Program {

        /*  Name:   PuzzleHunters (Mock Exam 1)
         *  Author: Prof. R.
         *  Date:   26 Feb 2021
         *  Desc:   A simple program that allows the user to enter the number of items
         *          within a store, then updates the inventory depending on if items 
         *          are sold (deduction) or purchased (added)
         */
        static void Main(string[] args) {
            const double COST = 19.95;      // define the item cost as a CONSTANT
            int inventoryCount = 0;         // variable to hold inventory count
            bool goodValue;                 // variable to use with TryParse
            int option;                     // option selected from menu
            int itemCount;                  // number of items purchased/sold
            double inventoryValue;          // Total value of the inventory in dollars

            // Display Header
            Console.WriteLine("*** Welcome to the Puzzle Hunters store! ***\n");

            // Get the number of puzzles currently in inventory
            Console.Write("Enter the number of puzzle games currently in the store: ");
            goodValue = int.TryParse(Console.ReadLine(), out inventoryCount);
            // Test to make sure we got a good value
            if (!goodValue || (inventoryCount < 0)) {
                // Bad value
                Console.Write("Invalid value entered -- Exiting\n");
                Environment.Exit(1);
            }

            // Display the menu
            Console.WriteLine("\n   1. Purchase puzzle games from the customer");
            Console.WriteLine("   2. Sell puzzle games to the customer");
            Console.WriteLine("   3. Display the current value of the inventory\n");

            // prompt and get the option.  Exit if invalid option
            Console.Write("Select one of the options above: ");
            goodValue = int.TryParse(Console.ReadLine(), out option);
            // test for valid entry and value between 1 and 3
            if ((!goodValue) || (option < 1) || (option > 3)) {
                Console.WriteLine("Invalid menu selection entered -- Exiting\n");
                Environment.Exit(2);
            }

            /* Note:  We don't need a default because we've already validated the
             *        entry.  We don't need a case 3 because that's the action
             *        that will be performed after case 1 or case 2 (it's the
             *        automatic default action.)
             */
            switch (option) {
                case 1:
                    // display sale prompt
                    Console.Write("How many puzzles are being sold to the store: ");
                    goodValue = int.TryParse(Console.ReadLine(), out itemCount);
                    if (!goodValue) {
                        Console.WriteLine("Invalid data entered -- Exiting");
                        Environment.Exit(3);
                    }
                    inventoryCount += itemCount;
                    break;
                case 2:
                    // display purchase prompt
                    Console.Write("How many puzzles are being purchased from the store: ");
                    goodValue = int.TryParse(Console.ReadLine(), out itemCount);
                    if (!goodValue) {
                        Console.WriteLine("Invalid data entered -- Exiting");
                        Environment.Exit(3);
                    }
                    inventoryCount += itemCount;
                    break;
            }   // end switch statement

            // Display the output
            inventoryValue = inventoryCount * COST;
            Console.WriteLine("\nPuzzle Games Inventory Value\n");
            Console.WriteLine($"Current number of puzzles in the store: {inventoryCount:N0}");
            Console.WriteLine($"Current value: {inventoryValue:C}");

            // end of program
        }
    }
}

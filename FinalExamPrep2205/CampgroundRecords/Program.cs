using System;
using System.Collections.Generic;

namespace CampgroundRecords {
    class Program {
        /// <summary>
        /// List holding campgrounds
        /// </summary>
        private List<Campground> campgrounds = new List<Campground>();

        
        static void Main(string[] args) {
            // Loop
            // Display MENU
            // Switch
            //Enter Campground Data
            //Enter report menu
            //Exit
            // End Loop
            int selection;
            do {
                selection = DisplayMainMenu();
                switch ( selection ) {
                    case 1:
                        EnterCampgroundData();
                        break;
                    case 2:
                        // Display report menu
                        break;
                    case 3:
                        //exit
                        Environment.Exit(0);
                }
            } while (true);

        }

        /// <summary>
        /// Display main menu choices
        /// </summary>
        public int DisplayMainMenu() {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// Enter data for a single campground
        /// </summary>
        public void EnterCampgroundData() {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// Displays error message
        /// </summary>
        /// <param name="_msg">Message to display as error</param>
        public void ErrorDisplay(string _msg) {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n\n***************");
            Console.WriteLine("*");
            Console.WriteLine("* " + _msg);
            Console.WriteLine("* Try again....");
            Console.WriteLine("*");
            Console.WriteLine("***************");
            Console.ResetColor();
        }
    }
}

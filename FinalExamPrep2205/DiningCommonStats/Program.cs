using System;

namespace DiningCommonStats {
	/// <summary>
	/// Program to collect information on items purchased by date
	/// </summary>
	/// <author>Prof. R.</author>
	/// <remarks>Being used for analysis on dining sales.</remarks>
	class Program {
		/// <summary>
		/// The date an item was purchased -- parallel to item array
		/// </summary>
		private static DateTime[] purchaseDate;
		/// <summary>
		/// Text array of item purchased -- parallel to purchase array
		/// </summary>
		private static string[] itemArray;

		/// <summary>
		/// Main entry point for the program
		/// </summary>
		/// <param name="args">Static values passed in from the command line</param>
		static void Main(string[] args) {
			int selection;
			int whichReport;
			InitializeArrays();
			do {
				selection = GetMenuSelection();
				switch (selection) {
					case 1:
						GetEntree();
						break;
					case 2:
						whichReport = ReportMenu();
						if ( whichReport != 0 ) BuildReport(whichReport); 
						break;
					case 3:
						Console.WriteLine("\n\nBye-Bye!");
						Environment.Exit(1);
						break;
                }
			} while (true);
		}

		/// <summary>
		/// Create empty arrays ready to receive data
		/// </summary>
		public static void InitializeArrays() {
			purchaseDate = new DateTime[0];
			itemArray = new string[0];
		}

		/// <summary>
		/// Displays menu and captures response.  Validation included
		/// </summary>
		public static int GetMenuSelection() {
			int choice;
			Console.WriteLine("\nMake a selection from the list below");
			Console.WriteLine("   1. Purchase an Entree");
			Console.WriteLine("   2. Entree/Purchase reports");
			Console.WriteLine("   3. Exit");
			Console.Write("Enter your choice (1,2,3):  ");
			if (!(int.TryParse(Console.ReadLine(), out choice))) {
				ErrorMsg("Error: You must enter 1, 2, or 3");
				choice = 0;
			} else {
				if ( choice < 1 || choice > 3) {
					ErrorMsg("Error: You must enter 1, 2, or 3");
					choice = 0;
                }
            }
			
			return choice;
		}

        /// <summary>
        /// Displays an error message in Red
        /// </summary>
        /// <param name="_msg">Error msg to display</param>
        public static void ErrorMsg(string _msg) {
			Console.ForegroundColor = ConsoleColor.Red;
			Console.WriteLine("\n\n***************");
			Console.WriteLine("*");
			Console.WriteLine("* " + _msg);
			Console.WriteLine("* Try again....");
			Console.WriteLine("*");
			Console.WriteLine("***************");
			Console.ResetColor();
		}

        /// <summary>
        /// Prompt user to enter item and date for a specific purpose
        /// </summary>
        public static void GetEntree() {
			string entree;
			DateTime date;
			Console.WriteLine("\n***Purchasing an Entree***");
			Console.Write("Enter the name of the Entre: ");
			entree = Console.ReadLine();
			if (string.IsNullOrWhiteSpace(entree)) {
				ErrorMsg("You must enter the name of the entree");
				return;
            }
			Console.Write("Enter the date the Entre was purchased (mm/dd/yyyy): ");
			if ( ! ( DateTime.TryParse(Console.ReadLine(), out date))) {
				ErrorMsg("You must enter a valid date");
				return;
            }
			// We've got the data -- load it up
			UpdateArrays(entree, date);
        }

        /// <summary>
        /// Add recently collected data to the arrays
        /// </summary>
        /// <param name="_entree">Name of the item purchased</param>
        /// <param name="_date">Date the item was purchased</param>
        public static void UpdateArrays(string _entree, DateTime _date) {
            // Note:  Length of the array gives us next pointer position
            // so length of zero (0) means our next entry should be in position 0
            int nextElement = purchaseDate.Length;

            // resize to length + 1
            Array.Resize(ref purchaseDate, nextElement + 1);
            Array.Resize(ref itemArray, nextElement + 1);

            // next element holds the index to the newly created element
            purchaseDate[nextElement] = _date;
            itemArray[nextElement] = _entree;
        }

        /// <summary>
        /// Displays the report menu and captures user selection
        /// </summary>
        /// <returns>User's selection</returns>
        public static int ReportMenu() {
			int choice;
			Console.WriteLine("\nMake a selection from the list below");
			Console.WriteLine("   1. List all purchases");
			Console.WriteLine("   2. List all purchases on a specific date");
			Console.WriteLine("   3. List all purchases for a specific item");
			Console.Write("Enter your choice (1,2,3):  ");
			if (!(int.TryParse(Console.ReadLine(), out choice))) {
				ErrorMsg("Error: You must enter 1, 2, or 3");
				choice = 0;
			} else {
				if (choice < 1 || choice > 3) {
					ErrorMsg("Error: You must enter 1, 2, or 3");
					choice = 0;
				}
			}

			return choice;

		}

        /// <summary>
        /// Configures system for reporting
        /// </summary>
        /// <param name="_choice">Integer indicating the report selected</param>
        public static void BuildReport(int _choice) {
            switch (_choice) {
                case 1:
                    DisplayAllEntries();
                    break;
				case 2:
					DisplayByDate();
					break;
				case 3:
					DisplayByEntree();
					break;
            }
        }

        /// <summary>
        /// Report for all items in the arrays
        /// </summary>
        public static void DisplayAllEntries() {
            string format = "{0,12}   {1}";
            string format2 = "{0,12:MM/dd/yyyy}   {1}";
            Console.WriteLine("\n*** ALL ENTREES ***\n");
            Console.WriteLine(format, "Purchased On", "Entree");
            for (int index = 0; index < purchaseDate.Length; index++) {
                Console.WriteLine(format2, purchaseDate[index], itemArray[index]);
            }
            Console.WriteLine($"{purchaseDate.Length} purchases displayed");
        }

        /// <summary>
        /// Report all items with a matching date
        /// </summary>
        public static void DisplayByDate() {
            DateTime date;
            int counter = 0;
            string format = "{0,12}   {1}";
            string format2 = "{0,12:MM/dd/yyyy}   {1}";
            Console.Write("Enter the date to display (mm/dd/yyyy): ");
            if (!(DateTime.TryParse(Console.ReadLine(), out date))) {
                ErrorMsg("You must enter a valid date");
                return;
            }
            Console.WriteLine($"\n*** ALL Purchases on {date.ToString("MM/dd/yyyy")} ***\n");
            Console.WriteLine(format, "Purchased On", "Entree");
            for (int index = 0; index < purchaseDate.Length; index++) {
                if (purchaseDate[index] == date) {
                    Console.WriteLine(format2, purchaseDate[index], itemArray[index]);
                    counter++;
                }
            }
            Console.WriteLine($"{counter} purchases displayed");
        }
        /// <summary>
        /// Report all items with a matching entree
        /// </summary>
        public static void DisplayByEntree() {
            string entree;
            int counter = 0;
            string format = "{0,12}   {1}";
            string format2 = "{0,12:MM/dd/yyyy}   {1}";
            Console.Write("Enter the entree to display: ");
            entree = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(entree)) {
                ErrorMsg("You must enter an entree name");
                return;
            }
            Console.WriteLine($"\n*** ALL Purchases of {entree} ***\n");
            Console.WriteLine(format, "Purchased On", "Entree");
            for (int index = 0; index < purchaseDate.Length; index++) {
                if (itemArray[index] == entree) {
                    Console.WriteLine(format2, purchaseDate[index], itemArray[index]);
                    counter++;
                }
            }
            Console.WriteLine($"{counter} purchases displayed");
        }


    }
}


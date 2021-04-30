using System;

/// <summary>
/// Part I of the final practice exam.  Simple IPO program.  No looping.
/// </summary>
/// <author>Prof. R.</author>
/// <date>2021-04-29</date>
 namespace TurnerCarSales {

        class Program {
        /// <summary>
        /// The make of the car
        /// </summary>
        private static string makeOfCar;
        /// <summary>
        /// The model of the car
        /// </summary>
        private static string modelOfCar;
        /// <summary>
        /// The cost for the car
        /// </summary>
        private static double costOfCar;
        /// <summary>
        /// The trade-in value
        /// </summary>
        private static double tradeinValue;
        /// <summary>
        /// The sales tax rate (7.3%)
        /// </summary>
        private static double salesTaxRate = 0.073;
        /// <summary>
        /// Car Cost - tradein value (if any)
        /// </summary>
        private static double subTotal;
        /// <summary>
        /// Calculated Tax Amount
        /// </summary>
        private static double taxAmount;
        /// <summary>
        /// Calculated Final Cost
        /// </summary>
        private static double totalCost;
        /// <summary>
        /// 12-month constant
        /// </summary>
        private const double PERIOD12 = 12.0;
        /// <summary>
        /// 24-month constant
        /// </summary>
        private const double PERIOD24 = 24.0;
        /// <summary>
        /// 48-month constant
        /// </summary>
        private const double PERIOD48 = 48.0;

        /// <summary>
        /// Main entry point for the software
        /// </summary>
        /// <param name="args">string array with values provided when the program starts</param>
        static void Main(string[] args) {
            CollectData();
            DoCalculations();
            DisplayResult();
        }

        /// <summary>
        /// Retrieve values populating the associated variables
        /// </summary>
        public static void CollectData() {
            Console.Write("Enter the make of the car:          ");
            makeOfCar = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(makeOfCar)) ErrorExit("You must enter the make of the car");
            Console.Write("Enter the model of the car:         ");
            modelOfCar = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(modelOfCar)) ErrorExit("You must enter the model of the car");
            Console.Write("Enter the cost for the car:         ");
            if (!(double.TryParse(Console.ReadLine(), out costOfCar)))
                ErrorExit("You must enter a valid numeric value for the cost of the car");
            if (costOfCar < 0) ErrorExit("Car Cost cannot be a negative value");
            Console.Write("Do they have a trade-in (Y/N):      ");
            if (((char.ToUpper(Console.ReadLine()[0])) == 'Y')) {
                Console.Write("What is the value of the trade-in?  ");
                if (!(double.TryParse(Console.ReadLine(), out tradeinValue)))
                    ErrorExit("You must enter a valid numeric value for the trade-in value");
            } else tradeinValue = 0;
            if (tradeinValue < 0) ErrorExit("Tradein Value cannot be less than 0");
        }

        /// <summary>
        /// Perform calculations using input data
        /// </summary>
        public static void DoCalculations() {
            subTotal = costOfCar - tradeinValue;
            taxAmount = subTotal * salesTaxRate;
            totalCost = subTotal + taxAmount;
        }

        /// <summary>
        /// Display results of calculations
        /// </summary>
        public static void DisplayResult() {
            string heading = "\n========> TURNER CAR SALES <========";
            string vehicle = $"\n{modelOfCar} - {makeOfCar}\n";
            string format1 = "{0,17} {1,11:C}";
            string format2 = "{0,17} {1,11:C} {2}";
            Console.WriteLine(heading);
            Console.WriteLine(vehicle);
            Console.WriteLine(format1, "Sale Price:", costOfCar);
            Console.WriteLine(format1, "Trade-in Value:", tradeinValue);
            Console.WriteLine(format1, "Subtotal:", subTotal);
            Console.WriteLine(format1, "Tax:", taxAmount);
            Console.WriteLine(format1, "Total:", totalCost);
            Console.WriteLine("\n****FINANCING****");
            Console.WriteLine(format2, "12 Months:", (totalCost / 12), "per month");
            Console.WriteLine(format2, "24 Months:", (totalCost / 24), "per month");
            Console.WriteLine(format2, "48 Months:", (totalCost / 48), "per month");
            Console.WriteLine("\n\n===>Goodbye...");
        }

        /// <summary>
        /// Displays provided error message than exits the program
        /// </summary>
        /// <param name="_msg">Error message to display</param>
        public static void ErrorExit(string _msg) {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n\n***************");
            Console.WriteLine("*");
            Console.WriteLine("* " + _msg);
            Console.WriteLine("* Exiting....");
            Console.WriteLine("*");
            Console.WriteLine("***************");
            Console.ResetColor();
            Environment.Exit(1);
        }
    }
}

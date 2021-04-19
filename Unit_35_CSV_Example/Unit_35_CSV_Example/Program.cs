using System;
using System.IO;

namespace Unit_35_CSV_Example {
    class Program {
        static string filePath = @"C:\Users\tjtics\Documents\Unit_35_Demo.txt";
        static StreamWriter writer;
           static void Main(string[] args) {

            OpenAndConfirmWriteMode();
            GetItemDetail();
            writer.Close();
            GetOut("We're all done!");
        }
        /// <summary>
        /// GetItemDetail allows the user to input any number of detail inventory records.  
        /// Upon collecting the data for each item (item number, name, unit price, description)
        /// the data is written to the output file as comma separated values
        /// </summary>
        static void GetItemDetail() {
            bool response;
            string itemNum;
            string description;
            string price;
            string quantity;
            string record;
            int count = 0;
            while (true) {
                response = ConfirmIt("\nDo you want to enter another record? ('Y') to continue");
                if (!response) break;

                Console.WriteLine("*** WARNING ***");
                Console.WriteLine("Enter data carefully -- there is NO error checking\n");
                Console.Write("Enter the item number: ");
                itemNum = Console.ReadLine();
                Console.Write("Enter the description: ");
                description = Console.ReadLine();
                Console.Write("Enter unit price: ");
                price = Console.ReadLine();
                Console.Write("Enter Quantity: ");
                quantity = Console.ReadLine();
                record = $"{itemNum},{description},{price},{quantity}";
                writer.WriteLine(record);
                count++;
            }
            Console.WriteLine($"\nYou added {count} records\n");
        }
        static void OpenAndConfirmWriteMode() {
            bool response;
            if (File.Exists(filePath)) {
                response = ConfirmIt("Enter 'Y' to create a NEW file with the same name; \nany other character to append to the file");
                if (response) {
                    writer = new StreamWriter(filePath);
                } else {
                    writer = File.AppendText(filePath);
                }
            } else {
                response = ConfirmIt("File Not Found.  Enter 'Y' to create a NEW file; \nany other character to exit the program");
                if (response) {
                    writer = new StreamWriter(filePath);
                } else {
                    GetOut("Exiting Program at user's request..... Good Bye");
                }
            }

        }
        static bool ConfirmIt(string _prompt) {
            Console.Write(_prompt +": ");
            string response = Console.ReadLine();
            return ((response.ToUpper() == "Y"));
        }
        
        static void GetOut(string _prompt) {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(_prompt);
            Console.ResetColor();
            Environment.Exit(1);
        }
    }
}

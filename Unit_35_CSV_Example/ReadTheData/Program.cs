using System;
using System.IO;

namespace ReadTheData {
        
    class Program {
    
        static string filePath = @"C:\Users\tjtics\Documents\Unit_35_Demo.txt";
        static StreamReader reader;
         static void Main(string[] args) {

            ConfirmFile();
            GetItemDetail();
            reader.Close();
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
            double price;
            int quantity;
            int count = 0;
            double inventoryValue = 0;

            Console.WriteLine("\n*** File Contents ***");
            Console.WriteLine("{0,-14} {1,-25} {2,12}  {3,8}", "Item Number", "Description", "Unit Price", "Quantity");
            Console.WriteLine("{0,-14} {1,-25} {2,12}  {3,8}", "===========", "===========", "==========", "========");

            while (!reader.EndOfStream) {
                string fullLine = reader.ReadLine();
                string[] fields = fullLine.Split(',');
                itemNum = fields[0];
                description = fields[1];
                price = Convert.ToDouble(fields[2]);
                quantity = Convert.ToInt32(fields[3]);
                Console.WriteLine("{0,-14} {1,-25} {2,12:C}  {3,8:N0}", itemNum, description, price, quantity);
                count++;
                inventoryValue += (price * quantity);
            }
            Console.WriteLine($"\nYou displayed {count} records\n");
            Console.WriteLine($"The total value of all items in inventory is {inventoryValue:C}");
        }
        static void ConfirmFile() {
            bool response;
            if (File.Exists(filePath)) {
                Console.WriteLine("File found successfully...continuing.");
                reader = new StreamReader(filePath);
            } else {
                response = ConfirmIt("File Not Found.  Press <Enter> to exit.");
                    GetOut("Exiting Program..... Good Bye");
            }

        }
        static bool ConfirmIt(string _prompt) {
            Console.Write(_prompt + ": ");
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

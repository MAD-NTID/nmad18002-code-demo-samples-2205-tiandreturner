using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace Unit36_Example {
    class Program {
        static List<Vehicle> vehicles = new List<Vehicle>();
        static List<Vehicle> newVehicles = new List<Vehicle>();
        static string jsonFile = @"C:\Users\tjtics\source\repos\nmad18002-code-demo-samples-2205-tiandreturner\Unit36_Example\vehicles.json";
        static string csvFile = @"C:\Users\tjtics\source\repos\nmad18002-code-demo-samples-2205-tiandreturner\Unit36_Example\vehicledata.csv";
        static void Main(string[] args) {
            string path = GetSourceFile();
            DataLoad(path);
            SaveJsonData(jsonFile);
            ReadJsonData(jsonFile);
            DisplayColor("Process completed. Press <enter> to exit", ConsoleColor.Green);
            Console.ReadLine();
        }

        public static void SaveJsonData(string _filename) {
            DisplayColor("Now, Serialize the data in the Dictionary into a single " +
                         "JSON formatted string\nPress <enter> to continue", ConsoleColor.Yellow);
            Console.ReadLine();
            string vehiclesStr = JsonConvert.SerializeObject(vehicles);
            StreamWriter writer = new StreamWriter(_filename); 
            writer.Write(vehiclesStr);
            writer.Close();
            DisplayColor("The Serialized JSON data has been written to the file\n" +
                         "Press <enter> to continue", ConsoleColor.Yellow);
            Console.ReadLine();
        }

        public static void ReadJsonData(string _filename) {
            DisplayColor("Open the JSON data file and read all data into a single string, \n" +
                         "then *deserialize* the data into a list.  Press <enter> to continue", ConsoleColor.Yellow);
            Console.ReadLine();
            StreamReader reader = new StreamReader(_filename);
            string vehicleStr = reader.ReadToEnd();
            newVehicles = JsonConvert.DeserializeObject<List<Vehicle>>(vehicleStr);
            reader.Close();
            DisplayColor("The data is now deserialized into a list of vehicles\nDisplay the data\n", ConsoleColor.Yellow);
            int count = 0;
            foreach ( Vehicle aVehicle in newVehicles ) {
                Console.WriteLine(aVehicle);

                count++;
            }
            DisplayColor($"\n{count} objects from the JSON file were read and parsed into a list object.\n" +
                         "Press <enter> to continue", ConsoleColor.Yellow);
            Console.ReadLine();
            
        }

        /// <summary>
        /// Reads a CSV file and loads the records into the dictionary
        /// </summary>
        static public void DataLoad(string _path) {
            string record;
            string plate;
            string plateState;
            int permitNumber;
            string firstName;
            string lastName;
            Vehicle_Type type;
            int count = 0;
            DisplayColor("Load Vehicle records into vehicle objects.  " +
                         "Load the objects into the Vehicles dictionary\nPress <enter> to continue",
                         ConsoleColor.Yellow);
            Console.ReadLine();
            StreamReader reader = new StreamReader(_path);
            while(! reader.EndOfStream ) {
                record = reader.ReadLine();
                string[] data = record.Split(',');
                plate = data[0];
                plateState = data[1];
                permitNumber = Convert.ToInt32(data[2]);
                firstName = data[3];
                lastName = data[4];
                type = (Vehicle_Type) Convert.ToInt32(data[5]);
                Vehicle aVehicle = new Vehicle(plate, plateState, permitNumber, firstName, lastName, type);
                vehicles.Add(aVehicle);
                Console.WriteLine(aVehicle.ToString());
                count++;
            }
            Console.WriteLine($"\n{count:n0} vehicle records loaded");
            DisplayColor("\nThe Data is now loaded in the dictionary\nPress <enter> to continue", ConsoleColor.Yellow);
            Console.ReadLine();
        }

        /// <summary>
        /// Obtains source CSV file name/path
        /// </summary>
        static public string GetSourceFile() {
            DisplayColor("\nFirst, get the name and path to the source data\nPress <enter> to continue.", ConsoleColor.Yellow);
            Console.ReadLine();
            Console.Write("Cut/Paste file name and path here (without quotes), then press enter\n" + 
                            "Blank entry loads default file: ");
            string path = Console.ReadLine();
            path = (string.IsNullOrEmpty(path) ? csvFile : path);
            if (!File.Exists(path)) {
                DisplayColor("\nERROR: File or Path does not exist... Exiting", ConsoleColor.Red);
                Environment.Exit(1);
            }
            return path;
        }
        static public void DisplayColor(string _msg, ConsoleColor _color) {
            Console.ForegroundColor = _color;
            Console.WriteLine(_msg);
            Console.ResetColor();
        }
    }
}

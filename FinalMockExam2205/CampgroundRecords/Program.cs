using System;
using System.Collections.Generic;

namespace CampgroundRecords
{
    class Program
    {
        const string MAIN = "main", REPORTS = "reports", NO_REPORTS = "No Record exists";
        const double BASELINE_DAILY_RATE = 30;
        static List<Campground> campgrounds;
        static string[] mainMenu = { "Enter a Campground", "Reports of Campgrounds" },
                reportMenu = {"Reports of all campgrounds", "Reports of all campgrounds with a rate less than $30 per day",
                              "Reports of all campgrounds with WiFi service", "Reports of all campgrounds with both WiFi service and a pool"};

        static int count;
        static void Main(string[] args)
        {
            campgrounds = new List<Campground>();
            while (true)
            {
                Console.Clear();
                Console.Write(Menu());
                switch (GetInput())
                {
                    case "1":
                        EnterCampground();
                        break;
                    case "2":
                        Console.WriteLine($"\n{GetCampgroundReports()}");
                        break;
                    default:
                        Console.WriteLine("Invalid Input -- Try Again");
                        break;
                }

                System.Threading.Thread.Sleep(5000);
            }

        }

        static string Menu(string menuType = MAIN)
        {
            string menuPrompt = "";
            string[] menu = menuType == REPORTS ? reportMenu : mainMenu;
            int index = 1;
            foreach (string prompt in menu)
               menuPrompt += $"{index++}. {prompt}\n";

            menuPrompt += "Select one of the options: ";
            return menuPrompt;
        }

        static void EnterCampground()
        {
            Console.Write("\nEnter the name of the campground: ");
            string name = GetInput();

            Console.Write("Enter the location of the campground: ");
            string location = GetInput();

            Console.Write("Enter the number of camping sites: ");
            int numberOfSites = 0;
            while (!int.TryParse(GetInput(), out numberOfSites))
            {
                Console.WriteLine("Error: Invalid Input -- Try Again");
                Console.Write("Enter the number of camping sites: ");
            }

            Console.Write("Enter the daily rate for the campground: ");
            double rate = 0;
            while (!double.TryParse(GetInput(), out rate))
            {
                Console.WriteLine("Error: Invalid Input -- Try Again");
                Console.Write("Enter the daily rate for the campground: ");
            }

            bool hasWiFi = YesOrNo("WiFi");
            bool hasPool = YesOrNo("pool");

            campgrounds.Add(new Campground(name, location, numberOfSites, rate, hasWiFi, hasPool));
            Console.WriteLine("Added the entry\n");
        }

        static bool YesOrNo(string prompt)
        {
            prompt = $"Does the campground have {prompt}? (Y/N): ";
            Console.Write(prompt);
            return GetInput().ToUpper()[0] == 'Y';
        }

        static string GetInput()
        {
            return Console.ReadLine();
        }

        static string GetCampgroundReports()
        {
            string reports;
            Console.Write($"\n{Menu(REPORTS)}");
            switch (GetInput())
            {
                case "1":
                    if (!RecordsExist(reports = AllReports()))
                        return NO_REPORTS;

                    return AddHeader(reports);
                case "2":
                    if (!RecordsExist(reports = AllReportsWithLessThanThirtyRate()))
                        return NO_REPORTS;
                    return AddHeader(reports);
                case "3":
                    if (!RecordsExist(reports = AllReportsWithWiFi()))
                        return NO_REPORTS;
                    return AddHeader(reports);
                case "4":
                    if (!RecordsExist(reports = AllReportsWithWiFiAndPool()))
                        return NO_REPORTS;
                    return AddHeader(reports);
                default:
                    return NO_REPORTS;
            }
        }

        static bool RecordsExist(string reports)
        {
            return reports != string.Empty;
        }

        static string AddHeader(string reports)
        {
            string header = "";
            header += "JT's Campground Compendium\n";
            header += DateTime.Now.ToString();
            header += $"\n{reports}";
            return header;
        }

        static string AllReports()
        {
            string allReports = "";

            foreach (Campground campground in campgrounds)
            {
                allReports += campground.ToString() + "\n";
            }

            if (campgrounds.Count != 0)
                allReports += $"Total Reports: {campgrounds.Count}";

            return allReports;
        }

        static string AllReportsWithLessThanThirtyRate()
        {
            string reports = "";
            
            count = 0;
            foreach (Campground campground in campgrounds)
            {
                if (campground.Rate < BASELINE_DAILY_RATE)
                {
                    reports += campground.ToString() + "\n";
                    count++;
                }
            }

            if (count != 0)
                reports += $"Total Reports: {count}";

            return reports;
        }

        static string AllReportsWithWiFi()
        {
            string reports = "";
            count = 0;
            foreach (Campground campground in campgrounds)
            {
                if (campground.HasWiFi)
                    reports += campground.ToString() + "\n";
            }

            if (count != 0)
                reports += $"Total Reports: {count}";
            return reports;
        }

        static string AllReportsWithWiFiAndPool()
        {
            string reports = "";
            count = 0;
            foreach (Campground campground in campgrounds)
            {
                if (campground.HasWiFi && campground.HasPool)
                    reports += campground.ToString() + "\n";
            }

            if (count != 0)
                reports += $"Total Reports: {count}";

            return reports;
        }
    }
}


using System;

namespace DiningCommonsStats
{
    class Program
    {
        static void Main(string[] args)
        {
            //Setting up variables
            string entree, date, menu = $"1. Purchase an entree\n2.Entree Reports\nSelect one of the options: ";
            string reportMenu = $"1. A Report for all entrees\n2. A report of all entrees purchased on a selected date\n" +
                $"3. A report of the dates/times of a selected entree\n Select one of the options: ";
            DateTime dt;

            //Parallel arrays - meaning that both will have equal lengths at all times to synchronize information
            string[] entrees = new string[0];
            DateTime[] dateTimes = new DateTime[0];

            //Outer loop
            while (true)
            {
                Console.Write(menu);

                //Outer switch
                switch (Console.ReadLine())
                {
                    //ADD ENTREE TO DATA BANK
                    case "1":
                        Console.Write("Enter the name of the entree: ");
                        entree = Console.ReadLine();
                        Console.Write("Enter the date of the purchased entree (Ex: 12/11/2019): ");
                        date = Console.ReadLine();
                        if (date != "")
                        {
                            while (!(DateTime.TryParse(date, out dt)))
                            {
                                Console.WriteLine("Error: Invalid Input - Try Again..");
                                Console.Write("Enter the date of the purchased entree (Ex: 12/11/2019): ");
                                date = Console.ReadLine();
                            }
                            Array.Resize(ref entrees, entrees.Length + 1);
                            Array.Resize(ref dateTimes, dateTimes.Length + 1);

                            entrees[entrees.Length - 1] = entree;
                            dateTimes[dateTimes.Length - 1] = dt;
                        }
                        else
                        {
                            Console.WriteLine("Invalid input");
                            break;
                        }
                        break;

                    //GENERATE REPORTS
                    case "2":
                        Console.Write(reportMenu);

                        switch (Console.ReadLine())
                        {
                            case "1":
                                Console.WriteLine("\n============ALL ENTREES===========");
                                Console.WriteLine($"{"Entree",-11}{"Purchased On",-12}");
                                for (int i = 0; i < entrees.Length; i++)
                                {
                                    Console.WriteLine($"{entrees[i],-11}{dateTimes[i].ToShortDateString(),-12}");
                                }

                                Console.WriteLine($"\nTotal Records: {entrees.Length}");
                                break;

                            case "2":
                                Console.Write("Enter the date of the purchased entree (Ex: 12/11/2019): ");

                                if (DateTime.TryParse(Console.ReadLine(), out dt))
                                {
                                    Console.WriteLine($"\n============ALL ENTREES ON {dt.ToShortDateString()}===========");
                                    int entreeCount = 0;
                                    for (int i = 0; i < entrees.Length; i++)
                                    {
                                        Console.WriteLine($"{entrees[i]}");
                                        entreeCount++;
                                    }
                                    Console.WriteLine($"\nTotal Records: {entreeCount}");
                                }
                                break;

                            case "3":
                                Console.Write("Enter the name of the purchased entree: ");
                                entree = Console.ReadLine();

                                Console.WriteLine($"\n============ALL DATES/TIMES ON {entree}===========");

                                int dtCount = 0;
                                for (int i = 0; i < entrees.Length; i++)
                                {
                                    if (entrees[i] == entree)
                                    {
                                        Console.WriteLine($"{dateTimes[i].ToShortDateString()}");
                                        dtCount++;
                                    }
                                }
                                Console.WriteLine($"\nTotal Records: {dtCount}");

                                break;
                        }
                        break;
                }//end outer switch

                Console.Write("Continue running the program? (Y/N): ");

                if (Console.ReadLine().ToUpper() == "Y")
                    continue;

                break;
            }
        }
    }
}

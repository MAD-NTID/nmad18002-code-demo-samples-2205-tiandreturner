using System;

namespace MAD4UFOS
{
    /**
     * MUST HAVE COMMENTS OTHERWISE YOU LOSE POINTS!
     *
     */
    class Program
    {
        static Alien[] aliens = new Alien[0];
        static void Main(string[] args)
        {
            int choice;

          //  DisplayHeading();

            while (true)
            {
                choice = GetMainMenuChoice();
                //Console.Clear();


                switch (choice)
                {

                    case 1:

                        EnterASighting();
                        Console.Write("Enter your name: ");
                        string name = Console.ReadLine();
                        int number = 0;
                        HelperMethod(name, number);
                        break;
                    case 2:
                        DisplayAllSightings();
                        
                        break;
                    case 3:
                        FilterBySpecies();
                        break;
                    case 4:
                        Console.WriteLine("Display Record Count");
                        Console.WriteLine($"{aliens.Length} sightings reported");
                        //DisplayRecordCount();
                        break;
                    case 5:
                        Console.WriteLine("Exiting Program");
                        Console.Write("Do you really want to exit (Y/N): ");
                        string yesOrNo = Console.ReadLine();
                        if (yesOrNo == "Y" || yesOrNo == "y")
                        {
                            Console.WriteLine("BYE BYE");
                            Environment.Exit(0);
                        }
                        //ExitProgram();
                        break;
                }
                //HelperMethod("0", 0);
                //HelperMethod(cool: 0, something: "2");
               
            }
        }

        public static void HelperMethod(string something, int cool)
        {
            Console.WriteLine($"hello {something}");
        }

        private static void FilterBySpecies()
        {
            int speciesCount = 0;
            Console.WriteLine("Filter by Species");

            Console.WriteLine("Enter the species name to list: ");
            string species = Console.ReadLine();

            for (int i = 0; i < aliens.Length; i++)
            {
                if(aliens[i].Name == species)
                {
                    Console.WriteLine(aliens[i]);
                    speciesCount++;
                }
            }
            Console.WriteLine($"{speciesCount} sightings reported");
        }

        private static void DisplayAllSightings()
        {
            Console.WriteLine("Display All Sightings");
            int speciesCount = 0;
           
            for (int i = 0; i < aliens.Length; i++)
            {
                Console.WriteLine(aliens[i]);
                speciesCount++;
            }

            Console.WriteLine($"{speciesCount} sightings reported");
        }

        private static void EnterASighting()
        {
            Console.WriteLine("Enter A Sighting");

            Console.Write("Enter the species for this sighting: ");
            string species = Console.ReadLine();
            if (species.Length == 0)
            {
                Console.WriteLine("    ===> You must enter a species");
                return;
            }

            Console.Write("Enter a date: ");
            DateTime date;
            string dateString = Console.ReadLine();
            if (dateString.Length == 0 || !DateTime.TryParse(dateString, out date))
            {
                Console.WriteLine("    ===> You must enter a valid date in mm/dd/yyyy format");
                return;
            }

     
            Console.Write("Enter the location (state) where the sighting occurred: ");
            string location = Console.ReadLine();
            if (location.Length == 0)
            {
                Console.WriteLine("    ===> You must enter a location (state)");
                return;

            }

            Alien alien = new Alien(species, date, location);


            Alien alien1 = new Alien();
            alien1.Name = "blah";

            string name1 = alien1.Name;

            int currentSize = aliens.Length;
            int newSize = currentSize + 1;
            Array.Resize(ref aliens, newSize);

            //aliens[currentSize] = alien;
            aliens[currentSize] = new Alien(species, date, location);
        }

        private static int GetMainMenuChoice()
        {
            int choice = 0;
            Console.WriteLine("Main Menu");
            Console.WriteLine("---------");
            Console.WriteLine("   1. Enter A Sighting");
            Console.WriteLine("   2. Display All Sightings");
            Console.WriteLine("   3. Display Sighting filtered by species");
            Console.WriteLine("   4. Display Record Count");
            Console.WriteLine("   5. Exit");
            Console.Write("Enter your selection (1-5): ");

            while (!int.TryParse(Console.ReadLine(), out choice) && (choice >= 1 && choice >=5))
            {
                Console.WriteLine("Invalid Input...Please Try Again");
                Console.Write("Enter your selection (1-5): ");
            }

            return choice;
        }

        private static void DisplayHeading()
        {
            Console.Clear();
            Console.WriteLine("MAD4UFOS Data Collection System");
            Console.WriteLine(DateTime.Now);
        }
    }
}
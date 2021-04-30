using System;

namespace DiningCommonsStatistics
{
    class Program
    {
        static string[] foodEntrees = new string[0];
        static DateTime[] foodDates = new DateTime[0];
        static void Main(string[] args)
        {
            bool flag = false;
            do
            {
                Console.WriteLine("1. Purchase an entree");
                Console.WriteLine("2. Entree Reports");
                int option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        int length = foodDates.Length;
                        Console.WriteLine("Enter the name of the entree: ");
                        string nameEntree = Console.ReadLine();

                        Console.WriteLine("Enter the date of the purchased entree (Ex. mm/dd/yyyy): ");
                        bool isDateTimeValid = true;
                        DateTime dt;
                        while(isDateTimeValid)
                        {
                            if(DateTime.TryParse(Console.ReadLine(), out dt))
                            {
                                Array.Resize(ref foodDates, length + 1);
                                foodDates[length] = dt;
                                isDateTimeValid = false;
                            }
                        }


                        break;
                    case 2:

                        break;
                    default:
                        break;
                }
            } while (flag);
        }

        static public void DisplayMenu()
        {

        }
    }
}

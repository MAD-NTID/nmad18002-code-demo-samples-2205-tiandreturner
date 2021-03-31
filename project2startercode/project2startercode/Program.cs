using System;

namespace project2startercode
{
    class Program
    {
        static void Main(string[] args)
        {
            Pizza[] pizzas = new Pizza[0];

            do
            {
                // ask for takeout or delivery

                // ask for size
                string size = DisplaySize();

                // ask for type of crust
                string typeOfCrust = DisplayTypeOfCrust();

                // ask for toppings
                DisplayToppings();

            } while (Exit());

            // display the recipt
                // list all of the pizzas
        }

        private static bool Exit()
        {
            Console.Write("Do you want to quit the program? (y/n): ");
            return false; // return whether if the user want to exit or not
        }
    }
}

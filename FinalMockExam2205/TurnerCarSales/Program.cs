using System;

namespace TurnerCarSales
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variables
            string make, model;
            double carPrice = 15000, carValue = 0, subTotal, taxAmount, totalCost;
            const double SALES_TAX = .073;  //7.3% sales tax

            Console.WriteLine("Welcome to the Turner Car Dealership!\n");

            //Collecting information from user
            Console.Write("What is the make of the car that the customer wish to purchase?: ");
            make = Console.ReadLine();

            Console.Write("What is the model of the car that the customer wish to purchase?: ");
            model = Console.ReadLine();

            Console.Write("Enter the price of the car: ");
            carPrice = int.Parse(Console.ReadLine());

            Console.Write("Does the customer want to trade in their vehicle? (Y/N): ");

            //Only prompt if customer wants to trade in
            if (Console.ReadLine().ToUpper() == "Y")
            {
                Console.Write("What is the value of the customer's vehicle?: ");
                carValue = int.Parse(Console.ReadLine());
            }

            //Calculate costs as per step 5
            subTotal = carPrice - carValue;
            taxAmount = subTotal * SALES_TAX;
            totalCost = subTotal + taxAmount;

            Console.WriteLine("\n\n===== Turner Car Sales =====\n");
            Console.WriteLine($"{"Sale Price:",15}{carPrice,15:C}");
            Console.WriteLine($"{"Trade-In Value:",15}{carValue,15:C}");
            Console.WriteLine($"{"Subtotal:",15}{subTotal,15:C}");
            Console.WriteLine($"{"Tax:",15}{taxAmount,15:C}");
            Console.WriteLine($"{"Total:",15}{totalCost,15:C}");
            Console.WriteLine($"{"12 Months:",15}{totalCost / 12,15:C} per month");
            Console.WriteLine($"{"24 Months:",15}{totalCost / 24,15:C} per month");
            Console.WriteLine($"{"48 Months:",15}{totalCost / 48,15:C} per month");
        }
    }
}

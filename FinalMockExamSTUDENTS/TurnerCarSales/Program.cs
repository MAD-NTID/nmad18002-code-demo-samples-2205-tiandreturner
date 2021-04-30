using System;

namespace TurnerCarSales
{
    class Program
    {
        static void Main(string[] args)
        {
            const double SALES_TAX = .073;
            Console.Write("Enter the make of the car to purchase: ");
            string carMake = Console.ReadLine();

            Console.Write("Enter the model of the car to purchase: ");
            string carModel = Console.ReadLine();

            Console.Write("Enter the price of the car: ");
            double carCost = double.Parse(Console.ReadLine());

            Console.Write("Does the customer want to trade in their vehicle? (Y/N): ");
            string tradeIn = Console.ReadLine().ToUpper();

            double carValue = 0;
            if(tradeIn == "Y")
            {
                Console.Write("Enter the value of the vehicle: ");
                carValue = double.Parse(Console.ReadLine()); 
            }

            double subtotal = carCost - carValue;
            double taxAmount = subtotal * SALES_TAX;
            double totalCost = taxAmount + subtotal;

            double divideByTweleve = totalCost / 12;
            double divideByTwentyFour = totalCost / 24;
            double divideByFortyEight = totalCost / 48;

            Console.WriteLine("\n===== Turner Car Sales =====\n");
            Console.WriteLine($"{carMake} {carModel}\n");
            Console.WriteLine($"Sale Price: {carCost:c2}");
            Console.WriteLine($"Trade-In Value: {carValue:c2}");
            Console.WriteLine($"Subtotal: {subtotal:c2}");
            Console.WriteLine($"Tax: {taxAmount:c2}");
            Console.WriteLine($"Total: {totalCost:c2}");
            Console.WriteLine($"12 Months: {divideByTweleve:c2} per month");
            Console.WriteLine($"24 Months: {divideByTwentyFour:c2} per month");
            Console.WriteLine($"48 Months: {divideByFortyEight:c2} per month");
        }
    }
}

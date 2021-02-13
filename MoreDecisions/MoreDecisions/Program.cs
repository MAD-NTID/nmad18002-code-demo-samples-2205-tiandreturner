using System;

/**
 * Name: Prof. Tiandre Turner
 * Course: NMAD-180.02 Programming Fundmentals I
 * Due Date: February 10, 2021 (or 02/10/2021)
 * Description: Expanded more on if/else and nested if statements
 * Caveats: No issue
 */
namespace MoreDecisions
{
    class Program
    {
        static void Main(string[] args)
        {

            const double HIGH_COMMISSION_RATE = 0.09; // REMEMBER this is FIXED!
            const double LOW_COMMISION_RATE = 0.06;

            Console.WriteLine("Enter the salesperson's name: ");
            string name = Console.ReadLine();

            Console.WriteLine("Enter the sale amount: ");
            string data = Console.ReadLine();
            double salesAmount = double.Parse(data);

            Console.WriteLine("Enter the car brand: ");
            string brand = Console.ReadLine();

            //Console.WriteLine("Enter the year of the car: ");
            //data = Console.ReadLine();
            //int year = int.Parse(data);

            double bonus = 0;
            double commission = 0;

            // if the saleperson is able to sell a car that is more than 10K
            // then, they get the commission.
            if (salesAmount >= 10000)
            {
                commission = salesAmount * HIGH_COMMISSION_RATE;

                if (brand == "Nissan")
                {
                    bonus = 750;
                }

                //if (year == 2004)
                //{
                //    bonus = 900;
                //}


            }
            else
            {
                commission = salesAmount * LOW_COMMISION_RATE;
            }

            

            Console.WriteLine("Salesperson: {0:C}", name);
            Console.WriteLine("Total Sales Amount: {0:C}", salesAmount);
            Console.WriteLine("Commission {0:C}", commission);
            Console.WriteLine("Bonus: {0:C}", bonus);
            Console.WriteLine("Total: {0:C}", commission + bonus);
        }
    }
}

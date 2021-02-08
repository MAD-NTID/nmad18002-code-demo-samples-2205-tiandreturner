using System;

/**
 * Name: Prof. Tiandre Turner
 * Course: NMAD-180.02 Programming Fundmentals I
 * Due Date: February 8, 2021 (or 02/08/2021)
 * Description: Used the ppt to demostrate how the flowchart works and
 *              it can be applied to coding
 * Caveats: No issue
 */
namespace Decisions
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(-40 > 2);

            const double COMMISSION_RATE = 0.07; // REMEMBER this is FIXED!

            Console.WriteLine("Enter the salesperson's name: ");
            string name = Console.ReadLine();

            Console.WriteLine("Enter the sale amount: ");
            string data = Console.ReadLine();
            double salesAmount = double.Parse(data);

            double commission = 0;

            // if the saleperson is able to sell a car that is more than 10K
            // then, they get the commission.
            if(salesAmount >= 10000)
            {
                commission = salesAmount * COMMISSION_RATE;
            }

            //Console.WriteLine("Salesperson: {0:C}", name);
            //Console.WriteLine("Total Sales Amount: {0:C}",  salesAmount);
            //Console.WriteLine("Commission {0:C}", commission);

            // another way to do the same thing as above.
            Console.WriteLine("Salesperson: {0}\nTotal Sales Amount: {1:C}\nCommission {2:C}", name, salesAmount, commission);


        }
    }
}

using System;

namespace LogicalOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            //const double HIGH_COMMISSION_RATE = 0.09; // REMEMBER this is FIXED!
            //const double LOW_COMMISION_RATE = 0.06;

            //Console.WriteLine("Enter the salesperson's name: ");
            //string name = Console.ReadLine();

            //Console.WriteLine("Enter the sale amount: ");
            //string data = Console.ReadLine();
            //double salesAmount = double.Parse(data);

            //Console.WriteLine("Enter the car brand: ");
            //string brand = Console.ReadLine();

            //double bonus = 0;
            //double commission = 0;

            //// if the saleperson is able to sell a car that is more than 10K
            //// then, they get the commission.
            //if (salesAmount >= 10000)
            //{
            //    commission = salesAmount * HIGH_COMMISSION_RATE;

            //}
            //else
            //{
            //    commission = salesAmount * LOW_COMMISION_RATE;
            //}

            //if(salesAmount >= 10000 && brand == "Nissan")
            //{
            //    bonus = 750;
            //}

            //Console.WriteLine("Salesperson: {0:C}", name);
            //Console.WriteLine("Total Sales Amount: {0:C}", salesAmount);
            //Console.WriteLine("Commission {0:C}", commission);
            //Console.WriteLine("Bonus: {0:C}", bonus);
            //Console.WriteLine("Total: {0:C}", commission + bonus);

            int var1 = -11;
            if(var1 >= -10 &&  var1 <= 10)
            {
                Console.WriteLine("You're in the range, brah!");
            }

            if (var1 < -10 ||  var1 > 10)
            {
                Console.WriteLine("You're out of the range, sista!");
            }
        }
    }
}

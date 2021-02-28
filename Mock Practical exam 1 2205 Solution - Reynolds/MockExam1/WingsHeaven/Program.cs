using System;

namespace WingsHeaven {

    /* Name:    WingsHeaven
     * Author:  Prof. R.
     * Date:    26 Feb 2021
     * Desc:    Simple restaurant-based program for the purchase of wings and side orders.
     *          Note that this takes an interesting approach in that it builds the receipt
     *          string as we go along.  By the time we reach the end, most of the receipt
     *          is already completed.  That string is then displayed with a single write
     *          statement.
     *          
     *          The approach used is intentional.  By placing all costs into constants,
     *          we can easily update any cost or rate.  For example, we can change the
     *          cost of boneless wings to 8.50 and everything will still calculate and
     *          display perfectly.
     */ 
    class Program {
        static void Main(string[] args) {
            const double COST_BONELESS = 7.99;
            const double COST_REGULAR = 9.99;
            const double DISCOUNT_RATE = .18;
            const double COST_BUFFALO_SAUCE = .29;
            const double COST_MILD_SAUCE = .39;
            const double COST_BBQ_SAUCE = .99;
            const double COST_NO_SAUCE = 0.0;
            const double COST_WAFFLE_FRIES = 3.49;
            const double COST_ONION_RINGS = 2.49;
            const double TAX_RATE = .08;

            // Even though it's the default, it's never a bad idea to set numeric values to zero when declared
            double subtotal = 0;
            double total = 0;
            string receipt = "\n\n*** WINGS HEAVEN ***\n\n";
            int choice;
            double discountAmount = 0;
            double taxAmount = 0;

            Console.WriteLine("Wings Heaven Order System\n");

            /* Note:    Notice how we use the constant to display the cost instead of embedding
             *          the value in the string.  By doing this, we minimize the effort of updating
             *          prices.  If we change the starting value of any of the cost constants, the
             *          strings will update to match.
             *          
             *          We've also used string interpolation with a twist!  Note the ",7" after each
             *          variable.  That means to right justify, 7 characters wide.  It makes everything
             *          line up neatly without a lot of bother!
             */
            Console.WriteLine($"   1. Boneless      ({COST_BONELESS,7:C})");
            Console.WriteLine($"   2. Traditional   ({COST_REGULAR,7:C})");
            Console.WriteLine($"   3. Both          ({(COST_BONELESS + COST_REGULAR),7:C})\n");

            Console.Write("Select the wing order: ");
            choice = int.Parse(Console.ReadLine()); // remember, the specification said all data entry is good.

            // determine which option was chosen then update the subtotal and the receipt string
            switch (choice) {
                case 1:         //Boneless
                    subtotal += COST_BONELESS;
                    receipt += ($"Boneless Wings     {COST_BONELESS,9:C}\n");
                    break;
                case 2:
                    subtotal += COST_REGULAR;
                    receipt += ($"Traditional Wings  {COST_REGULAR,9:C}\n");
                    break;
                case 3:
                    subtotal += COST_REGULAR + COST_BONELESS;
                    discountAmount = subtotal * DISCOUNT_RATE;
                    receipt += ($"Combination Order  {(COST_REGULAR + COST_BONELESS),9:C}\n");
                    receipt += ($"Combo Discount     {(discountAmount ), 9:C}-\n");
                    break;
            }

            // Display the sauce menu and get the user's response
            Console.WriteLine($"\n   1. Buffalo Sauce ({COST_BUFFALO_SAUCE,7:C})");
            Console.WriteLine($"   2. Mild Sauce    ({COST_MILD_SAUCE,7:C})");
            Console.WriteLine($"   3. BBQ Sauce     ({COST_BBQ_SAUCE,7:C})");
            Console.WriteLine($"   4. Plain         ({COST_NO_SAUCE,7:C})\n");

            Console.Write("Select the sauce type: ");
            choice = int.Parse(Console.ReadLine());

            // determine which option was chosen and update the subtotal and the receipt string
            switch (choice) {
                case 1:
                    subtotal += COST_BUFFALO_SAUCE;
                    receipt += ($"Buffalo Sauce      {COST_BUFFALO_SAUCE,9:C}\n");
                    break;
                case 2:
                    subtotal += COST_MILD_SAUCE;
                    receipt += ($"Mild Sauce         {COST_MILD_SAUCE,9:C}\n");
                    break;
                case 3:
                    subtotal += COST_BBQ_SAUCE;
                    receipt += ($"BBQ Sauce          {COST_BBQ_SAUCE,9:C}\n");
                    break;
                case 4:
                    subtotal += COST_NO_SAUCE;
                    receipt += ($"Plain (No sauce)   {COST_NO_SAUCE,9:C}\n");
                    break;
            }

            // Display the side order menu and get the user's response
            Console.WriteLine($"\n   1. Waffle Fries   ({COST_WAFFLE_FRIES,7:C})");
            Console.WriteLine($"   2. Onion Rings    ({COST_ONION_RINGS,7:C})");
            Console.WriteLine($"   3. Both           ({(COST_WAFFLE_FRIES + COST_ONION_RINGS),7:C})\n");
            
            Console.Write("Select the side order(s): ");
            choice = int.Parse(Console.ReadLine());

            // determine which option was chosen and update the subtotal and the receipt string
            switch (choice) {
                case 1:
                    subtotal += COST_WAFFLE_FRIES;
                    receipt += ($"Waffle Fries       {COST_WAFFLE_FRIES,9:C}\n");
                    break;
                case 2:
                    subtotal += COST_ONION_RINGS;
                    receipt += ($"Onion Rings        {COST_ONION_RINGS,9:C}\n");
                    break;
                case 3:
                    subtotal += COST_WAFFLE_FRIES + COST_ONION_RINGS;
                    receipt += ($"Rings and Fries    {(COST_WAFFLE_FRIES + COST_ONION_RINGS),9:C}\n");
                    break;
            }

            // Calculate the sales tax and the final total
            taxAmount = subtotal * TAX_RATE;
            total = subtotal + taxAmount;

            // add the subtotal, sales tax, total, and closing to the receipt
            receipt += ($"\nSubtotal           {subtotal,9:C}\n");
            receipt += ($"Tax                {taxAmount,9:C}\n");
            receipt += ($"Total              {total,9:C}\n\n");
            receipt += "THANK YOU!\n";

            // display the receipt
            Console.WriteLine(receipt);
       }
    }
}

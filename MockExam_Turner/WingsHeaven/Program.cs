using System;

namespace WingsHeaven
{
    class Program
    {
        /**
         * Name: Prof. Turner
         * Course: NMAD-180.02
         * Date: 02/26/2021
         * Description: Showing the students how would I develop it.
         * Caveats: Pending
         */
        static void Main(string[] args)
        {
            // WINGS
            const double BONELESS_WINGS_COST = 7.99;
            const double TRADITIONAL_WINGS_COST = 9.99;
            const double BOTH_WINGS_COST = 17.98;
            //const double BOTH_WINGS_COST = BONELESS_WINGS_COST + TRADITIONAL_WINGS_COST;

            // SAUCES
            const double BUFFALO_SAUCE_COST = 0.29;
            const double MILD_SAUCE_COST = 0.39;
            const double BBQ_SAUCE_COST = 0.99;

            // SIDES
            const double WAFFLE_FRIES_COST = 3.49;
            const double ONION_RINGS_COST  = 2.49;
            const double BOTH_SIDES_COST   = WAFFLE_FRIES_COST + ONION_RINGS_COST;

            // TAX AND DISCOUNT
            const double SALES_TAX = 0.08;
            const double DISCOUNT_PERCENTAGE = 0.18;

            // variables needed for the program
            int option               = 0;
            string selectedWings     = "";
            string selectedSauce     = "";
            string selectedSide = "";
            double selectedWingsCost = 0;
            double selectedSauceCost = 0;
            double selectedSidesCost = 0;

            Console.WriteLine($"   1. Boneless ({BONELESS_WINGS_COST:C})");
            Console.WriteLine($"   2. Traditional ({TRADITIONAL_WINGS_COST:C})");
            Console.WriteLine($"   3. Both ({BOTH_WINGS_COST:C})");

            Console.Write("\nSelect one of the preferred type of wings: ");
            option = int.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    selectedWings = $"Boneless Wings - {BONELESS_WINGS_COST:C}";
                    selectedWingsCost = BONELESS_WINGS_COST;
                    break;
                case 2:
                    selectedWings = $"Traditional Wings - {TRADITIONAL_WINGS_COST:C}";
                    selectedWingsCost = TRADITIONAL_WINGS_COST;
                    break;
                case 3:
                    double discountCost = BOTH_WINGS_COST * DISCOUNT_PERCENTAGE;
                    selectedWings = $"Combined Wings - {BOTH_WINGS_COST:C}\nDiscount - {discountCost:C}";
                    selectedWingsCost = BOTH_WINGS_COST - discountCost;
                    break;
            }

            Console.WriteLine($"   1. Buffalo Sauce ({BUFFALO_SAUCE_COST:C})");
            Console.WriteLine($"   2. Mild Sauce ({MILD_SAUCE_COST:C})");
            Console.WriteLine($"   3. BBQ Sauce ({BBQ_SAUCE_COST:C})");
            Console.WriteLine($"   4. Plain (no charge)");

            Console.Write("\nSelect one of the preferred type of wings: ");
            option = int.Parse(Console.ReadLine());

            if (option == 1)
            {
                selectedSauce = $"Buffalo Sauce - {BUFFALO_SAUCE_COST:C}";
                selectedSauceCost = BUFFALO_SAUCE_COST;
            }
            else if (option == 2)
            {
                selectedSauce = $"Mild Sauce - {MILD_SAUCE_COST:C}";
                selectedSauceCost = MILD_SAUCE_COST;
            }
            else if(option ==  3)
            {
                selectedSauce = $"BBQ Sauce - {BBQ_SAUCE_COST:C}";
                selectedSauceCost = BBQ_SAUCE_COST;
            }
            else
            {
                selectedSauce = "No Sauce";
            }

            Console.WriteLine($"   1. Waffle Fries ({WAFFLE_FRIES_COST:C})");
            Console.WriteLine($"   2. Onion Rings ({ONION_RINGS_COST:C})");
            Console.WriteLine($"   3. Both ({BOTH_SIDES_COST:C})");
            Console.WriteLine($"   4. None");

            Console.Write("\nSelect one of the preferred type of wings: ");
            option = int.Parse(Console.ReadLine());

            if (option == 1)
            {
                selectedSide = $"Waffle Fries - {WAFFLE_FRIES_COST:C}";
                selectedSidesCost = WAFFLE_FRIES_COST;
            }
            else if (option == 2)
            {
                selectedSide = $"Onion Rings - {ONION_RINGS_COST:C}";
                selectedSidesCost = ONION_RINGS_COST;
            }
            else if (option == 3)
            {
                selectedSide = $"Waffles Fries and Onion Rings - {BOTH_SIDES_COST:C}";
                selectedSidesCost = BOTH_SIDES_COST;
            }
            else
            {
                selectedSide = "No sides";
            }

            Console.WriteLine("Wings Heaven\n\n");

            Console.WriteLine(selectedWings);
            Console.WriteLine(selectedSauce);
            Console.WriteLine(selectedSide);

            double subtotal = selectedWingsCost + selectedSauceCost + selectedSidesCost;
            double tax = subtotal * SALES_TAX;
            double total = subtotal + tax;
            Console.WriteLine($"Subtotal: {subtotal:C}");
            Console.WriteLine($"Tax: {tax:C}");
            Console.WriteLine($"Total: {total:C}");
        }
    }
}

using System;

namespace HelperMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Enter the price and I will double for you!");
            //double money = double.Parse(Console.ReadLine());
            //double doubleMoney = DoubleMoney(money, 2);

            //Console.WriteLine(doubleMoney);

            PrintAnyNumberButFour(3); // GIVING THE VALUE of 3 TO the METHOD CALLED PrintAnyNumberButFour
            PrintAnyNumberButFour(24);// GIVING THE VALUE of 24 TO the METHOD CALLED PrintAnyNumberButFour
            PrintAnyNumberButFour(4); // GIVING THE VALUE of 4 TO the METHOD CALLED PrintAnyNumberButFour

            int firstNum = 0, secondNum = 0;
            int option = 0;
            int result = 0;
            string input = "";

            Console.Write("Enter the first number: ");

            firstNum = GetIntValue();

            //while (!int.TryParse(input = Console.ReadLine(), out firstNum))
            //{
            //    Console.WriteLine($"Error: {input} is not an numeric value. Please Try again.");
            //}

            Console.Write("Enter the second number: ");

            secondNum = GetIntValue();
            //while (!int.TryParse(input = Console.ReadLine(), out secondNum))
            //{
            //    Console.WriteLine($"Error: {input} is not an numeric value. Please Try again.");
            //}

            DisplayMenu();

            Console.Write("Select one of the operation: ");
            option = GetIntValue();
            //while (!int.TryParse(input = Console.ReadLine(), out option))
            //{
            //    Console.WriteLine($"Error: {input} is not an numeric value. Please Try again.");
            //}

            switch (option)
            {
                case 1:
                    result = firstNum + secondNum;
                    Console.WriteLine($"{firstNum} + {secondNum} = {result}");
                    ExitProgram();
                    break;
                case 2:
                    result = firstNum - secondNum;
                    Console.WriteLine($"{firstNum} - {secondNum} = {result}");
                    ExitProgram();
                    break;
                case 3:
                    result = firstNum * secondNum;
                    Console.WriteLine($"{firstNum} * {secondNum} = {result}");
                    ExitProgram();
                    break;
                case 4:
                    result = firstNum / secondNum;
                    Console.WriteLine($"{firstNum} / {secondNum} = {result}");
                    ExitProgram();
                    break;
            }


        }

        // this is a helper method
        // does not need any parameters ()
        // the goal for this method is to exit from the program.
        private static void ExitProgram()
        {
            Environment.Exit(0);
        }

        // this is a helper method
        // does not need any parameters ()
        // the goal for this method is to display the menu.
        private static void DisplayMenu()
        {
            Console.WriteLine("  1. Addition");
            Console.WriteLine("  2. Subtraction");
            Console.WriteLine("  3. Modulus");
            Console.WriteLine("  4. Division");
            
        }

        // this is a method with ONE PARAMETER and return an integer
        // For this parameter (int number) requires an integer NO MATTER WHAT.
        // the goal for this method is to validating the input and return an integer value.
        private static void PrintAnyNumberButFour(int number)
        {
            // if the number is four, return with nothing.. 
            if(number == 4)
            {
                // Do not proceed pass line 106
                return;
            }

            Console.WriteLine($"{number}, at least it is not four \\_/");
        }


        // this is a helper method but return an integer
        // does not need any parameters ()
        // the goal for this method is to validating the input and return an integer value.
        private static int GetIntValue()
        {
            string input;
            int number = 0;
            while (!int.TryParse(input = Console.ReadLine(), out number))
            {
                Console.WriteLine($"Error: {input} is not an numeric value. Please Try again.");
            }

            Console.WriteLine(number);

            return number;
        }

        private static double DoubleMoney(double number, int amountToMultiply)
        {
            Console.WriteLine($"Printing this number {number}");
            return number * amountToMultiply;
        }
    }
}

using System;

namespace HelperMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum = 0, secondNum = 0;
            int option = 0;
            int result = 0;
            string input = "";

            Console.Write("Enter the first number: ");

            while(!int.TryParse(input = Console.ReadLine(), out firstNum))
            {
                Console.WriteLine($"Error: {input} is not an numeric value. Please Try again.");
            }

            Console.Write("Enter the second number: ");

            while (!int.TryParse(input = Console.ReadLine(), out secondNum))
            {
                Console.WriteLine($"Error: {input} is not an numeric value. Please Try again.");
            }


            Console.WriteLine("  1. Addition");
            Console.WriteLine("  2. Subtraction");
            Console.WriteLine("  3. Multiplication");
            Console.WriteLine("  4. Division");
            Console.WriteLine("  5. Exit");
            Console.Write("Select one of the operation: ");

            while (!int.TryParse(input = Console.ReadLine(), out option))
            {
                Console.WriteLine($"Error: {input} is not an numeric value. Please Try again.");
            }

            switch(option)
            {
                case 1:
                    result = firstNum + secondNum;
                    Console.WriteLine($"{firstNum} + {secondNum} = {result}");
                    break;
                case 2:
                    result = firstNum - secondNum;
                    Console.WriteLine($"{firstNum} - {secondNum} = {result}");
                    break;
                case 3:
                    result = firstNum * secondNum;
                    Console.WriteLine($"{firstNum} * {secondNum} = {result}");
                    break;
                case 4:
                    result = firstNum / secondNum;
                    Console.WriteLine($"{firstNum} / {secondNum} = {result}");
                    break;
            }
        }
    }
}

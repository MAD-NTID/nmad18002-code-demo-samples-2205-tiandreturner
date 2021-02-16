using System;

namespace TryParse
{
    class Program
    {
        static void Main(string[] args)
        {
            const int RETIREMENT_AGE = 65;

            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            Console.Write("Enter your age: ");
            string inputValue = Console.ReadLine();
            //int age = int.Parse(inputValue);

            int age = 0;
            bool doesWork = int.TryParse(inputValue, out age);

            if (doesWork)
            {
                Console.WriteLine("Your name is " + name + " and you're " + age + " years old.");
            }
            else
            {
                Console.WriteLine("Your input, " + inputValue + ", is an invalid value. Please enter a whole number");
                Console.WriteLine("Exiting the program");
                System.Threading.Thread.Sleep(5000);
                Console.WriteLine("BYE BYE");
                Environment.Exit(0);
            }

            Console.Write("Enter your balance: ");
            string balanceInputValue = Console.ReadLine();
            double balance = 0;

            bool isBalanceNumber = double.TryParse(balanceInputValue, out balance);

            if (isBalanceNumber)
            {
                if(age >= RETIREMENT_AGE)
                {
                    Console.WriteLine("Congrats you have retired, we will add a million to your balance!");
                    balance = balance + 1000000;
                    Console.WriteLine("Your balance is $" + balance);
                }
                else
                {
                    Console.WriteLine($"Cool, here is your balance: {balance}");
                }
            }
            else
            {
                //Console.WriteLine("Your input, " + inputValue + ", is an invalid value. Please enter a whole number");
            }

            //Console.WriteLine("Your name is " + name);
            //Console.WriteLine( "Your name is {0} {1}", name, balance );
            //Console.WriteLine($"Your name is {name} ${balance}");
            //Console.WriteLine($"Your name is {name,-15} {balance,15:C0}");

            // example of the differences between string interpolation
            //Console.WriteLine($"{name} has a bank balance of {balance:C}");
            //Console.WriteLine("{0,-10}, who is {1,4:N0} has a balance of {2,15:C}", name, age, balance);
        }
    }
}

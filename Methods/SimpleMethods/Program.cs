using System;

namespace SimpleMethods
{
    class Program
    {
        static void Main(string[] args)
        {

            Foreground(ConsoleColor.Red);
            //Console.ForegroundColor = ConsoleColor.Red;
            //DisplayHelloWorld(); // Console.WriteLine("Hello World!");
            //Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.DarkBlue;
            DisplayHelloWorld(); //Console.WriteLine("Hello World!");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Yellow;
            DisplayHelloWorld(); // Console.WriteLine("Hello World!");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Cyan;
            DisplayHelloWorld(); //Console.WriteLine("Hello World!");
            Console.ResetColor();

            //ReciptHeader();

            // rest of the recipt

            Console.BackgroundColor = ConsoleColor.Magenta;
            PromptUser("Enter your name: "); // Console.Write("Enter your name: ");
            //GetInput();
            string name = GetInput();

            PromptUser("Enter your age: "); //Console.Write("Enter your age: ");
            //GetInput();
            int age = GetInt();

            PromptUser("Enter an number: "); //Console.Write("Enter an number: ");
           // GetInput();
            int number = GetInt();

            Console.WriteLine($"Your name is {name} and you're {age} years old! Your favorite number is {number}");
        }

        private static void Foreground(ConsoleColor color)
        {
            Console.ForegroundColor = color;
            DisplayHelloWorld(); // Console.WriteLine("Hello World!");
            Console.ResetColor();
        }

        // this is called a helper method
        private static void DisplayHelloWorld()
        {
            Console.WriteLine("Hello World!");
        }

        private static void ReciptHeader()
        {
            Console.WriteLine("Wegmans");
            Console.WriteLine("123 John Road");
        }

        private static int GetInt()
        {
            return int.Parse(GetInput());
        }

        //private static void GetInput()
        //{
        //    Console.ReadLine();
        //}

        private static string GetInput()
        {
            return Console.ReadLine();
        }

        private static void PromptUser(string msg)
        {
            Console.Write(msg);
        }

    }
}

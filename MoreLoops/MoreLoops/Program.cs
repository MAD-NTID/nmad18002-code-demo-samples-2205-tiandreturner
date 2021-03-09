using System;

namespace MoreLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            // for loops
            //int counter;
            //for(counter = 1; counter <= 10; counter++)
            //{
            //    Console.WriteLine(counter);
            //}

            //while loops

            //Console.WriteLine("While Loop");
            //int counter = 5;
            //while (counter <= 10)
            //{
            //    Console.WriteLine(counter);
            //    counter++;
            //}
            //Console.WriteLine("Do-While Loop");
            //int count = 5;
            //do
            //{
            //    Console.WriteLine(count);
            //    count++;
            //} while (count <= 10);

            //do
            //{
            //    int number = 0;
            //    Console.Write("Enter a number that count up to 10: ");

            //    while (!int.TryParse(Console.ReadLine(), out number))
            //    {
            //        Console.WriteLine("Error: Invalid Number, please try again.");
            //        Console.Write("Enter a number: ");
            //    }

            //    for (; number <= 10; number++)
            //    {
            //        Console.WriteLine(number);
            //    }

            //    Console.WriteLine("Do you want to try again? (y/n): ");
            //} while (Console.ReadLine() == "y");

            Random rng = new Random();

            int number = rng.Next(1,100); //80
            int guess = 0;
            while(true)
            {
                Console.Write("Enter a number (1-100): ");
                guess = int.Parse(Console.ReadLine());

                if(guess >= number - 5 &&  guess <= number - 1)
                {
                    Console.WriteLine("You get warmer");
                }
                else if(  guess >= number + 1 && guess <= number + 5)
                {
                    Console.WriteLine("You get colder");
                }
                else if(guess < number)
                {
                    Console.WriteLine("You get closer");
                }
                else if(guess > number)
                {
                    Console.WriteLine("You get farther");
                }


                if(guess == number)
                {
                    Console.WriteLine("You guessed it right!");
                    break;
                }

              //  Console.WriteLine("AW SUCKS! Keep guessing!");
            }
        }
    }
}

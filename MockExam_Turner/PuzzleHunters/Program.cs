using System;

namespace PuzzleHunters
{
    /**
     * Name: Prof. Turner
     * Course: NMAD-180.02
     * Date: 02/26/2021
     * Description: Showing the students how would I develop it.
     * Caveats: Pending
     */
    class Program
    {
        static void Main(string[] args)
        {
            const double COST_OF_EACH_PUZZLE = 19.95;
            int currentNumberOfPuzzleGames = 0;
            int numberOfPuzzleGames = 0;
            int option = 0;
            double total = 0;

            Console.WriteLine("*** Welcome to the Puzzle Hunters store! ***");

            Console.Write("Enter the number of the puzzle games currently in the store: ");

            if (!int.TryParse(Console.ReadLine(), out currentNumberOfPuzzleGames))
            {
                Console.WriteLine("Error: Invalid Input.\nExiting the program.");
                Environment.Exit(0);
            }

            if (currentNumberOfPuzzleGames <= 0)
            {
                Console.WriteLine("Error: the digit cannot be negative.\nExiting the program.");
                Environment.Exit(0);
            }

            //if (int.TryParse(Console.ReadLine(), out currentNumberOfPuzzleGames))
            //{
            //    if (currentNumberOfPuzzleGames <= 0)
            //    {
            //        Console.WriteLine("Error: the digit cannot be negative.\nExiting the program.");
            //        Environment.Exit(0);
            //    }

            //    Console.WriteLine("\n      1.Purchase puzzle games from the customers");
            //    Console.WriteLine("      2.Sell puzzle games to the customers");
            //    Console.WriteLine("      3.Display the current value of the inventor\n");

            //    Console.WriteLine($"Select one of the options: ");

            //    if (int.TryParse(Console.ReadLine(), out option))
            //    {
            //        if (option == 1)
            //        {
            //            Console.Write("How many puzzle games would you like to purchase: ");
            //            int numberOfPuzzleGames = int.Parse(Console.ReadLine());

            //            if (int.TryParse(Console.ReadLine(), out numberOfPuzzleGames))
            //            {
            //                currentNumberOfPuzzleGames = currentNumberOfPuzzleGames + numberOfPuzzleGames;
            //                total = currentNumberOfPuzzleGames * COST_OF_EACH_PUZZLE;
            //            }
            //            else
            //            {
            //                Console.WriteLine("Error: Invalid Input.\nExiting the program.");
            //                Environment.Exit(0);
            //            }

            //            Console.WriteLine($"Current number of puzzle games in the store - {currentNumberOfPuzzleGames}");
            //            Console.WriteLine($"Current Value - {total:C}");
            //        }
            //        else if (option == 2)
            //        {
            //            Console.Write("How many puzzle games would you like to sell: ");

            //            if (int.TryParse(Console.ReadLine(), out numberOfPuzzleGames))
            //            {
            //                currentNumberOfPuzzleGames = currentNumberOfPuzzleGames - numberOfPuzzleGames;
            //                total = currentNumberOfPuzzleGames * COST_OF_EACH_PUZZLE;
            //            }
            //            else
            //            {
            //                Console.WriteLine("Error: Invalid Input.\nExiting the program.");
            //                Environment.Exit(0);
            //            }

            //            Console.WriteLine($"Current number of puzzle games in the store - {currentNumberOfPuzzleGames}");
            //            Console.WriteLine($"Current Value - {total:C}");
            //        }
            //        else if (option == 3)
            //        {
            //            total = currentNumberOfPuzzleGames * COST_OF_EACH_PUZZLE;
            //        }
            //        else
            //        {
            //            Console.WriteLine("Error: You did not selected one of the given options.\nExiting the program.");
            //            Environment.Exit(0);
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine("Error: Invalid Input.\nExiting the program.");
            //        Environment.Exit(0);
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Error: Invalid Input.\nExiting the program.");
            //    Environment.Exit(0);
            //}

            Console.WriteLine("\n      1. Purchase puzzle games from the customers");
            Console.WriteLine("      2. Sell puzzle games to the customers");
            Console.WriteLine("      3. Display the current value of the inventor\n");

            Console.WriteLine($"Select one of the options: ");


            if (!int.TryParse(Console.ReadLine(), out option))
            {
                Console.WriteLine("Error: Invalid Input.\nExiting the program.");
                Environment.Exit(0);
            }

            switch (option)
            {
                case 1:

                    Console.Write("How many puzzle games would you like to purchase: ");

                    if (!int.TryParse(Console.ReadLine(), out numberOfPuzzleGames))
                    {
                        Console.WriteLine("Error: Invalid Input.\nExiting the program.");
                        Environment.Exit(0);
                    }

                    currentNumberOfPuzzleGames = currentNumberOfPuzzleGames + numberOfPuzzleGames;
                    total = currentNumberOfPuzzleGames * COST_OF_EACH_PUZZLE;
                    break;
                case 2:

                    Console.Write("How many puzzle games would you like to sell: ");

                    // if the entered input is not a digit
                    if (!int.TryParse(Console.ReadLine(), out numberOfPuzzleGames))
                    {
                        Console.WriteLine("Error: Invalid Input.\nExiting the program.");
                        Environment.Exit(0);
                    }

                    //switch ()
                    //{ }


                    currentNumberOfPuzzleGames = currentNumberOfPuzzleGames - numberOfPuzzleGames;
                    total = currentNumberOfPuzzleGames * COST_OF_EACH_PUZZLE;

                    break;
                case 3:
                    total = currentNumberOfPuzzleGames * COST_OF_EACH_PUZZLE;
                    break;
                default:
                    Console.WriteLine("Error: You did not selected one of the given options.\nExiting the program.");
                    Environment.Exit(0);
                    break;
            }


            Console.WriteLine($"Current number of puzzle games in the store - {currentNumberOfPuzzleGames}");
            Console.WriteLine($"Current Value - {total:C}");




        }
    }
}

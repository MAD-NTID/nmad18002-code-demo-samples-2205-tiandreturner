using System;

namespace Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Enter ");

            int number = 6;

            //if (number == 1 || number == 2)
            //{
            //    Console.WriteLine("Number 1 or 2");
            //}

            if (number == 2)
            {
                Console.WriteLine("Number 2");
            }
            else if (number == 1)
            {
                Console.WriteLine("Number 1");
            }
            else
            {
            }

            switch (number)
            {
                case 2:
                    Console.WriteLine("Number 1 or 2");
                    break;
                case 1:
                    break;
                default:
                    Console.WriteLine("No match dude");
                    break;
            }

            Console.Write("Guess a fruit: ");
            string fruit = Console.ReadLine().ToUpper();

            //if (fruit == "mango" || fruit == "Mango")
            //{

            //}

            switch(fruit)
            {
                case "mango":
                //case "Mango":
                    Console.WriteLine("Sweet, you guessed it right! it is mango!");
                    break;
                case "banana":
                    Console.WriteLine("Sweet, you guessed it right! it is banana!");
                    break;
                case "blueberry":
                    Console.WriteLine("Sweet, you guessed it right! it is blueberry!");
                    break;
                case "orange":
                    Console.WriteLine("Sweet, you guessed it right! it is orange!");
                    break;
                case "not apple":
                    Console.WriteLine("Sweet, you guessed it right! it is not apple!");
                    break;
                default:
                    Console.WriteLine("AW man, you got it wrong.");
                    break;
            }

        }
    }
}

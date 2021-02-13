using System;

namespace If_Else_Statements
{
    class Program
    {
        static void Main(string[] args)
        { 
            int score = 85;
            if (score < 100)
            {
                if (score < 90)
                {
                    if (score < 80)
                    {
                        if (score < 70)
                        {
                            if (score < 60)
                                Console.WriteLine("You got an F.");
                            else
                                Console.WriteLine("You got a D.");
                        }
                        else
                        {
                            Console.WriteLine("You got a C.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("You got a B.");
                    }
                }
                else
                {
                    Console.WriteLine("You got an A.");
                }
            }
            else
            {
                Console.WriteLine("You got a perfect score!");
                Console.WriteLine("You got an A!");
            }
        }
    }
}

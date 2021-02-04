using System;

namespace CastingAndSimpleInputs
{
    class Program
    {
        static void Main(string[] args)
        {
            //int totalMinutes = 87;
            //int hours = (int)(totalMinutes / 60.0);
            //int minutes = totalMinutes % 60;
            //Console.WriteLine(totalMinutes + " is equal to " +hours + " and " 
            //    + minutes + " minutes");

            //byte b = 8;
            //short short1 = 16;

            //short1 = b; // implict

            //b = (byte)short1; // explict

            //int integer = 3;
            //double double1 = 3.27;

            //int integer2 = (int)double1;

            //int wholeNumber = 0;
            //double something = 12.5;
            //double number2 = 2.0;
            //wholeNumber = (int)(something / number2);

            //Console.Write("Enter your name: ");
            //string name = Console.ReadLine();

            //Console.WriteLine("Enter your age: ");
            ////string data = Console.ReadLine();
            ////int age = int.Parse(data);
            //int age = int.Parse(Console.ReadLine());

            //Console.WriteLine("Hello " + name + " and you're " 
            //    + age + " years old!");

            //Console.WriteLine("You will be " + (age + 7) + " in seven years!");

            //Console.WriteLine("Bank Account Statement: ");
            //double balance = double.Parse(Console.ReadLine());

            //int score1;
            //int score2;

            //Console.WriteLine("The first score: ");
            //string input = Console.ReadLine();
            //int score1 = int.Parse(input);

            //Console.WriteLine("The second score: ");
            //string input2 = Console.ReadLine();

            //int score2 = int.Parse(input2);
            //double averageScore = (score1 + score2) / 2.0;
            ////Console.WriteLine("The first score is: " + score1);
            ////Console.WriteLine("The second score is: " + score2);
            //Console.WriteLine("The average is: " + averageScore);

            int score1;
            int score2;

            Console.WriteLine("The first score: ");
            string input = Console.ReadLine();
            score1 = int.Parse(input);

            Console.WriteLine("The second score: ");
            input = Console.ReadLine();

            score1 = 0;


            score2 = int.Parse(input);
            double averageScore = (score1 + score2) / 2.0;
            //Console.WriteLine("The first score is: " + score1);
            //Console.WriteLine("The second score is: " + score2);
            Console.WriteLine("The average is: " + averageScore);

        }
    }
}

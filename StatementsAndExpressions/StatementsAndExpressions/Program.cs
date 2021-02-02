using System;

/**
 * Author: Professor Turner
 * Course: NMAD-180.02
 * Date: 02/01/2021
 * Description: Explained briefly on statements and expressions
 * Caveats: CAVEATS means there are some issues in your code that
 *          you were unable to fix. HOWEVER, please comment the code out
 *          and point out the line number so I know where to look for.
 */
namespace StatementsAndExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            int myAge = 25;
            myAge = 23;
            Console.WriteLine(myAge);

            // Arithmetic operations
            //int subtotal = 13;
            //int total = subtotal + 2;


            // What happened if we use string with arithemtic operations?
            int subtotal = 13;
            string total = subtotal + 2 + "a";
            Console.WriteLine(total);
            total = "a" + subtotal + 2;
            Console.WriteLine(total);
            // using PEMDAS concept
            total = "a" + (subtotal + 2);
            Console.WriteLine(total);

            // integer division
            Console.WriteLine(2 / 2);
            Console.WriteLine(3 / 2);

            // how to use modulus
            Console.WriteLine(0.2 % 0.2);
            Console.WriteLine(3 % 2);
            Console.WriteLine(2 % 4 % 2);

            // many different ways to do regular division.
            Console.WriteLine(3.0 / 2.0);
            Console.WriteLine(3 / 2.0);
            Console.WriteLine(3.0 / 2);

            int number1 = 5;
            double number2 = 2;
            Console.WriteLine(number1 / number2);

            // an constant
            const int NUMBER_OF_STUDENTS = 7;
            Console.WriteLine(NUMBER_OF_STUDENTS);
        }
    }
}

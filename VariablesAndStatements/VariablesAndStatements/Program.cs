using System;

/**
 * Author: Tiandre Turner 
 * Course: NMAD-180.02
 * Date: January 29, 2021 (or 01/29/2021)
 * Description: Demostrating the concepts of variables and statements
 * Caveats: None
 */
namespace VariablesAndStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            // an example of single line comment.
            Console.WriteLine("Hello World!");

            /*
             * An example of multi-line comments
             */

            int age;

            //blah
            //blah 
            Console.WriteLine("Hello World!");
            Console.WriteLine("Hello World!");
            Console.WriteLine("Hello World!");
            Console.WriteLine("Hello World!");
            Console.WriteLine("Hello World!");
            Console.WriteLine("Hello World!");
            Console.WriteLine("Hello World!");

            // declare a variable
            int myAge; // variable declaration 
            // assign the value to a variable
            myAge = 26;

            //int myAge = 26;

            // declare AND assign the value to a variable
            // variable initialization
            int number = 23;
            int number2 = 50;
            string number3 = "38";
            string sentence = "Hello my name is ";
            string name = "Prof. Turner";
            string space = " "; // good practice if you want to reuse this variable
                                // FOR LINES 55-56
            Console.WriteLine(number);
            Console.WriteLine(number2);
            Console.WriteLine(number + number2);
            Console.WriteLine(number3 + number3);

            // two different ways to produce same result.
            Console.WriteLine(sentence + "Prof. Turner");
            Console.WriteLine(sentence + name);

            // two different ways to produce similar result.
            Console.WriteLine(number3 + space + number);
            // two different ways to produce same result.
            Console.WriteLine(number + space + number3);
            Console.WriteLine(number + " " + number3);


        }
    }
}

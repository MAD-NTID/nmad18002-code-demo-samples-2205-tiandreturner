using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[4];
            numbers[0] = 36;
            numbers[1] = 3;
            numbers[2] = 7;
            numbers[3] = 11;

            int number1 = 36;
            int number2 = 3;

            string[] students = new string[8];
            students[0] = "Menna";
            students[1] = "TJ";
            students[2] = "Sahand";
            students[3] = "David";
            //string[] students = { "Menna", "TJ", "Sahand", "David" };

            Console.WriteLine($"Menna have {numbers[0]}");
            Console.WriteLine($"{students[2]} have {numbers[2]}");

            int[] myArray = new int[5];
            myArray[0] = 23;
            myArray[4] = 11;
        }
    }
}

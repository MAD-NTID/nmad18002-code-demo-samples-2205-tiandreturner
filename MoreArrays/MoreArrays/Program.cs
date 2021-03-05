using System;

namespace MoreArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            for(int index = 1; index <= 3; index += 2)
            {
                Console.WriteLine(index);
               sum = sum + index;
                //sum -= index;
            }

            Console.WriteLine("total: " + sum);
            const int SIZE = 4;
            int[] numbers = new int[SIZE];

            Console.WriteLine($"Current size of numbers is: {numbers.Length}");
            for (int index = 0; index < numbers.Length; index++)
            {
                Console.Write("Enter an number: ");
                numbers[index] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("How many do you want to add more: ");
            int moreNumbersToAdd = int.Parse(Console.ReadLine());

            Array.Resize(ref numbers, numbers.Length + moreNumbersToAdd);
            Console.WriteLine($"Current size of numbers is: {numbers.Length}");

            for (int index = moreNumbersToAdd - 1; index < numbers.Length; index++)
            {
                Console.Write("Enter an number: ");
                numbers[index] = int.Parse(Console.ReadLine());
            }

            //int sum = 0;

            //for(int index = 0; index < numbers.Length; index++)
            //{
            //    Console.WriteLine(numbers[index]);
            //    sum = sum + numbers[index];
            //}

            //Console.WriteLine("Total: " + sum);





        }
    }
}

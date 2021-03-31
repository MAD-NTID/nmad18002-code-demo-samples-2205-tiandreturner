using System;

namespace _2DArrays
{
    class Program
    {
        static string[] sports = { "Basketball", "Football", "Soccer", "Volleyball", "Baseball" };
        static void Main(string[] args)
        {
            // remove an element from array
            DisplayAll();
            Console.Write("Select an element to remove from an array: ");
            int indexToRemove = int.Parse(Console.ReadLine());
            Remove(indexToRemove);
            DisplayAll();


            // 2D arrays
            //int[,] numbers = new int[2, 2];
            //numbers[0, 0] = 12;
            //numbers[0, 1] = 14;
            //numbers[1, 0] = 13;
            //numbers[1, 1] = 15;

            //for (int row = 0; row < numbers.GetLength(0); row++)
            //{
            //    for (int col = 0; col < numbers.GetLength(1); col++)
            //    {
            //        Console.WriteLine(numbers[row, col]);
            //    }
            //}

            //int[,,] dNumbers = new int[2, 2, 2];
            //dNumbers[0, 0, 0] = 4;
            //dNumbers[0, 1, 0] = 42;
            //dNumbers[0, 1, 1] = 6;

            //for (int row = 0; row < dNumbers.GetLength(0); row++)
            //{
            //    for (int col = 0; col < dNumbers.GetLength(1); col++)
            //    {
            //        for (int zIndex = 0; zIndex < dNumbers.GetLength(2); zIndex++)
            //        {
            //            Console.WriteLine(dNumbers[row, col,zIndex]);
            //        }
            //    }
            //}
        }

        public static void DisplayAll()
        {
            for (int i = 0; i < sports.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {sports[i]}");
            }
        }

        public static void Remove(int index)
        {
            for(int i = index; i < sports.Length; i++)
            {
                sports[i-1] = sports[i];
                Console.WriteLine($"{sports[i-1]} = {sports[i]}");
            }

            Array.Resize(ref sports, sports.Length - 1);
        }
    }
}

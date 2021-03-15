using System;

namespace MoreMethods
{
    class Program
    {
         static int firstNum = 0;
        static void Main(string[] args)
        {

            int firstNum = 0;
            //Console.Write("Enter the first number: ");
            //int firstNum = int.Parse(Console.ReadLine());

            //Console.Write("Enter the second number: ");
            //int secondNum = int.Parse(Console.ReadLine());

            //Random rand = new Random();

            //rand.Next(1, 100);
            //rand.Next();
            //rand.Next(50,7);

            //Add(5.7, 5.9);
            //Add(5, 9);
            //Add(5);

            //int.TryParse(Console.ReadLine(), out int something);


            //Console.WriteLine(Add());
            //Console.WriteLine(Add(5));
            //Console.WriteLine(Add(5,5));
            //Console.WriteLine(Add(5, 11));
            //Console.WriteLine(Add(5, 15));

            ////Display();
            //Display("Tiandre");
            //Display("Menna", favoriteSport: "Volleyball");
            //Display("Yunhao", "3rd Year", "Badmination");
            //Display(gradeLevel: "5th Year", name: "Sahand");
            //Display(1, 2);

            //int value1 = 20;
            //int value2 = 40;
            //int total;
            //double average;

            //total = TotalAndAverage(value1, value2, out average);

            //Console.WriteLine("Total is:" +total);
            //Console.WriteLine("Average is:" + average);

            double resultSQ = SquareTime(6, 4, out double result);

            Console.WriteLine("Result is:" + result);
            Console.WriteLine("ResultSQ is:" + resultSQ);
            // Result
            // Total is: 60
            // Average is: 30.0
        }

        private static double SquareTime(double x, double y, out double result)
        {
            result = Math.Pow(x, 2) / y;
            return (x - y) * (Math.Sqrt(y));
        }

        //private static double AverageAndMultiply(double val, double val2, out double result)
        //{
        //    result = val * val2;
        //    return (val + val2) / 2;
        //}

        private static int TotalAndAverage(int value1, int value2, out double average)
        {
            average = (value1 + value2) / 2.0;
            return (value1 + value2);
        }


        private static void Display(int something, int something1)
        {

        }

        private static void Display(string name, string gradeLevel = "4th Year", string favoriteSport = "Basketball")
        {
            Console.WriteLine($"Hi! My name is {name} and I am {gradeLevel}. My favorite sport is {favoriteSport}");
        }


        private static double Add(double x, double y)
        {
            return x + y;
        }

        private static int Add(int x, int y = 5)
        {
            return x + y;
        }

        private static int Add(int x = 10)
        {
            return x + firstNum;
        }

  
        //private static void Add(double firstNum)
        //{

        //}
    }
}

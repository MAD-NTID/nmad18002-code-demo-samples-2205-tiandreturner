using System;

namespace SkateboardExample
{
    class Program
    {
        static Skateboard[] skateboards = new Skateboard[0];
        static void Main(string[] args)
        {
            //Skateboard[] skateboards = new Skateboard[0];

            //Skateboard defaultSkateboard = new Skateboard();
            //skateboards[0] = defaultSkateboard;

            //Console.WriteLine("Enter the number of wheels on your skateboard: ");
            //int numOfWheels = int.Parse(Console.ReadLine());

            //Console.WriteLine("Enter the type of your skateboard: ");
            //string type = Console.ReadLine();

            //Console.WriteLine("Enter the color of your skateboard: ");
            //string color = Console.ReadLine();

            //Skateboard anotherSkateboard = new Skateboard();
            //anotherSkateboard.NumOfWheels = numOfWheels;
            //anotherSkateboard.TypeOfBoard = type;
            //anotherSkateboard.Color = color;

            //skateboards[1] = anotherSkateboard;

            //Console.WriteLine("Enter the number of wheels on your skateboard: ");
            //int numOfWheels = int.Parse(Console.ReadLine());

            //Console.WriteLine("Enter the type of your skateboard: ");
            //string type = Console.ReadLine();

            //Console.WriteLine("Enter the color of your skateboard: ");
            //string color = Console.ReadLine();

            //Skateboard skateboard = new Skateboard(numOfWheels, type, color);
            //Console.WriteLine(skateboard.ToString());

            //skateboards[2] = skateboard;

            //skateboard.Color = "Blue";
            //Console.WriteLine(skateboard.ToString());

            //Console.WriteLine(skateboards[2].ToString());

            while (true)
            {
                GetRecordOfSkateboard();
                Console.WriteLine("Do you want to add more skateboard? (y/n): ");

                if (Console.ReadLine() != "y")
                {
                    break;
                }
            }

            Console.WriteLine("Show all the list of skateboards");
            for (int i = 0; i < skateboards.Length; i++)
            {
                Console.WriteLine(  skateboards[i]  );
                Console.WriteLine();
            }

        }

        public static void GetRecordOfSkateboard()
        {
            Console.WriteLine("Enter the number of wheels on your skateboard: ");
            int numOfWheels = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the type of your skateboard: ");
            string type = Console.ReadLine();

            Console.WriteLine("Enter the color of your skateboard: ");
            string color = Console.ReadLine();

            Skateboard skateboard = new Skateboard(numOfWheels, type, color);
            Array.Resize(ref skateboards, skateboards.Length + 1);

            skateboards[skateboards.Length - 1] = skateboard;
        }


    }
}

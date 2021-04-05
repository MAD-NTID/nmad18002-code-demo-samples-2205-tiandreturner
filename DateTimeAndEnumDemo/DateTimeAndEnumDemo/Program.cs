using System;

namespace DateTimeAndEnumDemo
{
    class Program
    {
        enum ClassMates { Menna, Alvin, Sahand };
        enum Size { Small, Medium, Large};
        enum BreedOfDogs {  BlueHeelers = 5, Husky, GermanShepard = 10, GoldenRetriver, Poodle};
        enum Sport { Basketball, Baseball, Soccer, Football };
        static void Main(string[] args)
        {
            DateTime dateTime = DateTime.Now;

            Console.WriteLine(dateTime);
            Console.WriteLine(dateTime.ToShortDateString());
            Console.WriteLine(dateTime.ToLongDateString() + " " + dateTime.ToShortTimeString());
            Console.WriteLine(dateTime.ToLongDateString() + " " + dateTime.ToLongTimeString());

           // DateTime date = dateTime.AddDays(4);
           //date = date.AddMonths(13);
           // date = date.AddYears(-6);
           // date = date.AddHours(-13);

            DateTime date = dateTime.AddMonths(-5).AddDays(27).AddYears(2).AddMinutes(60); // chaining methods
            Console.WriteLine(date);

            //switch(Size.Small)
            //{
            //    case Size.Small:
            //        Console.WriteLine("You picked small");
            //        break;
            //    case Size.Medium:
            //        Console.WriteLine("You picked med");
            //        break;
            //    case Size.Large:
            //        Console.WriteLine("You picked large");
            //        break;
            //}

            //int sport = RandomSport();
            //switch (sport)
            //{
            //    case (int)Sport.Basketball:
            //        Console.WriteLine("BASKETBALL");
            //        break;
            //    case (int)Sport.Baseball:
            //        Console.WriteLine("BASEBALL");
            //        break;
            //    case (int)Sport.Soccer:
            //        Console.WriteLine("SOCCER");
            //        break;
            //    case (int)Sport.Football:
            //        Console.WriteLine("FOOTBALL");
            //        break;
            //}


            //Sport sport = (Sport)RandomSport();
            //switch (sport)
            //{
            //    case Sport.Basketball:
            //        Console.WriteLine("BASKETBALL");
            //        break;
            //    case Sport.Baseball:
            //        Console.WriteLine("BASEBALL");
            //        break;
            //    case Sport.Soccer:
            //        Console.WriteLine("SOCCER");
            //        break;
            //    case Sport.Football:
            //        Console.WriteLine("FOOTBALL");
            //        break;
            //}
        }

        public static int RandomSport()
        {
            Random rng = new Random();

            return rng.Next(Enum.GetNames(typeof(Sport)).Length); 
        }
    }
}

using System;
using System.IO;


namespace ReadCSVFile
{
    class Program
    {
        static string filePath = @"C:\Users\tjtics\Documents\books.txt";
        static void Main(string[] args)
        {
            ReadFile();

        }

        private static void ReadFile()
        {
            long isbn;
            string author;
            string title;
            int year;
            int count = 0;

            if (File.Exists(filePath))
            {
                Console.WriteLine("File found successfully...start to loading...");
                StreamReader reader = new StreamReader(filePath);

                Console.WriteLine("\n*** File Contents ***");
                Console.WriteLine("{0,-14} {1,-25} {2,12}  {3,8}", "ISBN", "Title", "Author", "Year");
                Console.WriteLine("{0,-14} {1,-25} {2,12}  {3,8}", "===========", "===========", "==========", "========");

                while (!reader.EndOfStream)
                {
                    string fullLine = reader.ReadLine();
                    string[] fields = fullLine.Split(',');
                    isbn = long.Parse(fields[0]);
                    title = fields[1];
                    author = fields[2];
                    year = Convert.ToInt32(fields[3]);
                    Console.WriteLine("{0,-14} {1,-25} {2,12}  {3,8}", isbn, title, author, year);
                    count++;
                }
                Console.WriteLine($"\nYou displayed {count} records\n");
                reader.Close();
            }
            else
            {
                Console.WriteLine("File is not found...exiting from the program...");
                Environment.Exit(0);
            }
        }
    }
}

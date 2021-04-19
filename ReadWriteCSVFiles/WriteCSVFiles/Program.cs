using System;
using System.IO;

namespace WriteCSVFiles
{
    class Program
    {
        static string filePath = @"C:\Users\tjtics\Documents\books.txt";
        static StreamWriter writer;

        static void Main(string[] args)
        {
            OpenFile();
            WriteBookDetailsToFile();
            Console.WriteLine("Wrote the book details to the file successfully!");
        }

        private static void WriteBookDetailsToFile()
        {
            string isbn;
            string author;
            string title;
            string year;

            int count = 0;

            do
            {
                Console.WriteLine("*** WARNING ***");
                Console.WriteLine("Enter data carefully -- there is NO error checking\n");
                Console.Write("Enter the ISBN: ");
                isbn = Console.ReadLine();
                Console.Write("Enter the title: ");
                title = Console.ReadLine();
                Console.Write("Enter the author ");
                author = Console.ReadLine();
                Console.Write("Enter the published year: ");
                year = Console.ReadLine();
                writer.WriteLine($"{isbn},{title},{author},{year}");
                count++;

                Console.Write("Do you want to enter another record? ('Y') to continue: ");
            }while (Console.ReadLine().ToUpper() == "Y") ;
            Console.WriteLine($"\nYou added {count} records\n");

            writer.Close();
        }

        private static void OpenFile()
        {
           if(File.Exists(filePath))
           {
                Console.Write("The file you selected exists, do you wish to overwrite the file?"
                    + "\nNote: If you do not wish to overwrite, it will apprend the text to the file. (Y/N): ");
                
                if(Console.ReadLine().ToUpper() == "Y")
                {
                    // WILL OVERWRITE THE FILE
                    writer = new StreamWriter(filePath);
                }
                else
                {
                    // There are two ways to apprend texts to a file
                    //writer = File.AppendText(filePath);

                    // OR

                    writer = new StreamWriter(filePath,true);
                }


            }
           else
            {
                Console.Write("The file you selected do not exist, do you wish to create the file?"
                    + "\nOtherwise you will exit from the program. (Y/N): ");

                if (Console.ReadLine().ToUpper() == "Y")
                {
                    // WILL OVERWRITE THE FILE
                    writer = new StreamWriter(filePath);
                }
                else
                {
                    Console.WriteLine("Exiting from the program!");
                    writer.Close();
                    Environment.Exit(0);
                }
            }
        }
    }
}

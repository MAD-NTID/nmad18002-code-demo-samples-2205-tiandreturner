using System;
using System.IO;

namespace ReadingFromFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            string pf1fileName = @"C:\Users\tjtics\Documents\pf1.txt";
            string fileName = @"C:\Users\tjtics\Documents\pf2.txt";

            Console.WriteLine("ACCESSING PF1.TXT");
            ReadFile(pf1fileName);

            Console.WriteLine("\n\nACCESSING PF2.TXT");
            ReadFile(fileName);


            Console.WriteLine("\n\nACCESSING PF1.TXT");
            StreamWriter writer = new StreamWriter("pf1.txt");// automatically goes to the bin folder if not specify the path
            writer.WriteLine("\"Life is better if you have no homework\" - Menna");
            writer.WriteLine("\"Make peace and be kind\" - Bill");
            writer.WriteLine("\"i Don't Know\" - Alvin");
            writer.WriteLine("\"This is full of BS\" - Sahand");
            writer.WriteLine("\"Just do it\" - Yunhao");
            writer.WriteLine("\"Ummmmm\" - Megan");
            writer.Close();

            ReadFile(pf1fileName);
        }

        public static void ReadFile(string fileName)
        {
            bool isExist = File.Exists(fileName);

            if (isExist)
            {
                StreamReader reader = new StreamReader(fileName);

                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    Console.WriteLine(line);
                }

                reader.Close();
            }
            else
            {
                Console.WriteLine("The file that you specified does not exist");
            }
        }
    }
}

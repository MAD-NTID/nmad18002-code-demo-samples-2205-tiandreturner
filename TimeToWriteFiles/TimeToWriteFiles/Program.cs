using System;
using System.IO;

namespace TimeToWriteFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamWriter writer = new StreamWriter("PFI_Text.txt");

            writer.WriteLine("\"Woof Woof\" - SAHAND & DAKOTA");
            writer.WriteLine("\"Gaming\" - Alvin");
            writer.WriteLine("\"Hello NTID!\" - Yunhao");
            writer.WriteLine("\"Coffee\" - Erica");
            writer.WriteLine("\"Welcome to Spring!\" - Ash");

            // You can use a loop to repeat multiple WriteLines 
            //StreamWriter writer = new StreamWriter("PFI_Text-MS");
            //Console.Write("How many times do you want to use a loop: ");
            //int times = int.Parse(Console.ReadLine());
            //for (int i = 0; i < times; i++)
            //{
            //    writer.WriteLine("\"Woof Woof\" - SAHAND & DAKOTA");
            //    writer.WriteLine("\"Gaming\" - Alvin");
            //    writer.WriteLine("\"Hello NTID!\" - Yunhao");
            //    writer.WriteLine("\"Coffee\" - Erica");
            //    writer.WriteLine("\"Welcome to Spring!\" - Ash");
            //    writer.WriteLine($"----------INDEX {i}----------");
            //}


            writer.Close();

        }
    }
}

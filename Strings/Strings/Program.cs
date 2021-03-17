using System;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            //string text = "Alright Alright Alright! You gonna learn today!";

            // original
            //Console.WriteLine(text);

            // uppercase
            // Console.WriteLine(text.ToUpper());

            // lowercase
            //Console.WriteLine(text.ToLower());

            // Get Characters from a string using array
            //char[] arr = text.ToCharArray();
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.WriteLine(arr[i]);
            //}

            // Get Specific Characters from a string using array
            //char[] arr1 = text.ToCharArray(8,7);
            //for(int i = 0; i < arr1.Length; i++)
            //{
            //    Console.WriteLine(arr1[i]);
            //}

            //string text = "Alright Alright Alright! You gonna learn today!";

            //// Get substring from a string
            //Console.WriteLine(text.Substring(25));
            //Console.WriteLine(text.Substring(25,3));


            //// reverse
            //char[] characters = text.ToCharArray();
            //Array.Reverse(characters);
            //string backName = new string(characters);
            //Console.WriteLine(backName);

            //// Find a position of t
            //Console.WriteLine($"t is found at position {text.IndexOf("t")}");

            //int index = 0;
            //while((index = text.IndexOf("t")) != -1)
            //{
            //    Console.WriteLine($"t is found at position {index++}");
            //}

            // Split
            string text = "Alright Alright Alright! You gonna learn today!";
            char[] delimiters = { ' ', '!' };
            string[] arr = text.Split(delimiters);


            for(int i = 0; i < arr.Length; i++)
                Console.WriteLine($"position {i} -- {arr[i]}");

        }
    }
}
